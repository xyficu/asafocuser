using ASCOM.DriverAccess;
using System.Diagnostics;

namespace ASAFocuser
{
    class FocuserUser
    {
        private Focuser m_focuser;
        private FocuserParams m_focParams;
        string m_deviceID = "";

        public FocuserUser()
        {
            m_focParams = new FocuserParams();
            
        }

        //连接ASCOM驱动接口，启动ASA自带控制程序
        public void ConnectDevice()
        {
            try
            {
                if (m_focuser == null)
                {
                    //从配置文件获取Focuser ID
                    //TBD
                    if (m_deviceID == "")
                    {
                        m_deviceID = Focuser.Choose("ACCServer.Focuser");
                        if (m_deviceID == null || m_deviceID == "")
                        {
                            m_focParams.errMsg = "Can not find \'ACCServer.Focuser\' in ASCOM driver";
                            Debug.Write(m_focParams.errMsg);
                        }
                        else
                        {
                            //保存调焦器名称到配置文件TBD
                            m_focuser = new Focuser(m_deviceID);
                            m_focParams.connected = true;
                        }
                    }
                    else
                    {
                        m_focuser = new Focuser(m_deviceID);
                        m_focParams.connected = true;
                    }

                }
                //else if (m_focuser.Dispose())
                //{
                //    //断开后再连接
                //    m_focuser = new Focuser(m_deviceID);
                //    m_focParams.connected = true;
                //}

            }
            catch (System.Exception ex)
            {
                m_focParams.connected = false;
                m_focParams.errMsg = ex.Message;
            }
        }

        //设置温度补偿
        public void SetTempComp(bool tempComp)
        {
            try
            {
                if (null != m_focuser || m_focuser.Connected == true)
                {
                    if (m_focuser.TempCompAvailable)
                    {
                        m_focuser.TempComp = tempComp;
                    }
                }
            }
            catch (System.Exception ex)
            {
                m_focuser = null;
                m_focParams.errMsg = ex.Message;
            }
        }

        //获取温度补偿
        public bool GetTempComp()
        {
            try
            {
                if (null != m_focuser || m_focuser.Connected == true)
                {
                    if (m_focuser.TempCompAvailable)
                    {
                        return m_focuser.TempComp;
                    }
                }
                return false;
            }
            catch (System.Exception ex)
            {
                m_focuser = null;
                m_focParams.errMsg = ex.Message;
                return false;
            }
        }

        //获取位置
        public double GetCurPos()
        {
            try
            {
                if (null != m_focuser || m_focuser.Connected == true)
                {
                    return m_focuser.Position / 1000.0;
                }
                else
                    return 0;
            }
            catch (System.Exception ex)
            {
                m_focuser = null;
                m_focParams.errMsg = ex.Message;
                return 0;
            }

        }

        //获取温度
        public double GetCurTemp()
        {
            try
            {
                if (null != m_focuser || m_focuser.Connected == true)
                {
                    return m_focuser.Temperature;
                }
                else
                    return 0;
            }
            catch (System.Exception ex)
            {
                m_focuser = null;
                m_focParams.errMsg = ex.Message;
                return 0;
            }

        }

        //获取移动状态
        public bool GetMoveStatus()
        {
            try
            {
                if (null != m_focuser || m_focuser.Connected == true)
                {
                    return m_focuser.IsMoving;
                }
                else
                    return false;
            }
            catch (System.Exception ex)
            {
                m_focuser = null;
                m_focParams.errMsg = ex.Message;
                return false;
            }
        }

        //获取连接状态
        public bool GetLink()
        {
            try
            {
                if (null != m_focuser)
                    return m_focParams.connected;
                else
                    return false;
            }
            catch (System.Exception ex)
            {
                m_focuser = null;
                m_focParams.errMsg = ex.Message;
                return false;
            }
        }

        public string GetDevErrStat()
        {
            return m_focParams.errMsg;
        }

        //指定位置移动
        public void FocuserMoveToPos(double targetPos)
        {
            try
            {
                targetPos *= 1000;
                targetPos = System.Math.Round(targetPos);
                if (m_focuser != null && m_focuser.Connected == true)
                {
                    m_focuser.Move((int)targetPos);
                }
            }
            catch (System.Exception ex)
            {
                m_focuser = null;
                m_focParams.errMsg = ex.Message;
            }
        }

        //步长移动
        public void FocuserStepMove(double step)
        {
            try
            {
                int curPos = 0;
                step *= 1000;
                if (m_focuser != null && m_focuser.Connected == true)
                {
                    curPos = m_focuser.Position;
                    m_focuser.Move(curPos + (int)step);
                }
            }
            catch (System.Exception ex)
            {
                m_focuser = null;
                m_focParams.errMsg = ex.Message;
            }

        }

        //急停
        public void FocuserStop()
        {
            try
            {
                if (m_focuser != null && m_focuser.Connected == true)
                {
                    m_focuser.Halt();
                }
            }
            catch (System.Exception ex)
            {
                m_focuser = null;
                m_focParams.errMsg = ex.Message;
            }
        }

        //日志记录
        public void FocuserLog()
        {
            try
            {
                if (null != m_focuser && m_focuser.Connected == true)
                {
                    //保存数据到文件，主要是温度和位置
                }
            }
            catch (System.Exception ex)
            {
                m_focuser = null;
                m_focParams.errMsg = ex.Message;
            }

        }
    }
}
