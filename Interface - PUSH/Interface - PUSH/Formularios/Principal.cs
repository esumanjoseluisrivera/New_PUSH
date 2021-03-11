
using BLL;
using Interface___PUSH.Clases;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Utils;    
using Dal;

namespace Interface___PUSH
{
    public partial class Principal : Form

    {
        // PagaID, aqui no va // private int _currentPageId = (int)PageIdEnum.Device;
        //public DeviceBll _bllDevice = new DeviceBll();
        //public DeviceCmdBll _bll = new DeviceCmdBll();
        private string _devSN = null;

        private Dictionary<String, int> _dicDevInterval = new Dictionary<String, int>();
        private Dictionary<string, string> _dicCmd = new Dictionary<string, string>();

        private string[] devCmd = new string[100];
        DeviceBll _bll = new DeviceBll();
        DataTable _dtDevice = null;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObtenerIP();
            LoadCmd();
        }

        private void ObtenerIP()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            cmbIP.Text = "";

            //Obtiene la dirección del servidor y solo conserva la dirección IPV4
            foreach (IPAddress ip in ipHost.AddressList)
            {
                if (!Regex.IsMatch(ip.ToString(), @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$"))
                {
                    continue;
                }

                cmbIP.Items.Add(ip.ToString());
            }

            cmbIP.SelectedIndex = 0;
        }

        private void LoadCmd()
        {
            //cmbControl
            _dicCmd.Add("Reboot", Commands.Command_ControlReboot);
            _dicCmd.Add("UnLock", Commands.Command_ControlUnLock);
            _dicCmd.Add("UnAlarm", Commands.Command_ControlUnAlarm);
            _dicCmd.Add("Info", Commands.Command_ControlInfo);
            cmbControl.Items.AddRange(new string[] { "Reboot", "UnLock", "UnAlarm", "Info" });

            //cmbUpdate
            _dicCmd.Add("UpdateUserInfo", Commands.Command_UpdateUserInfo);
            //_dicCmd.Add("UpdateIDCard", Commands.Command_UpdateIDCard);
            _dicCmd.Add("UpdateFingerTmp", Commands.Command_UpdateFingerTmp);
            _dicCmd.Add("UpdateFaceTmp", Commands.Command_UpdateFaceTmp);
            _dicCmd.Add("UpdateFvein", Commands.Command_UpdateFvein);
            _dicCmd.Add("UpdateBioData", Commands.Command_UpdateBioData);
            _dicCmd.Add("UpdateUserPic", Commands.Command_UpdateUserPic);
            _dicCmd.Add("UpdateSMS", Commands.Command_UpdateSMS);
            _dicCmd.Add("UpdateUserSMS", Commands.Command_UpdateUserSMS);
            _dicCmd.Add("UpdateAdPic", Commands.Command_UpdateAdPic);
            _dicCmd.Add("UpdateWorkCode", Commands.Command_UpdateWorkCode);
            _dicCmd.Add("UpdateShortcutKey", Commands.Command_UpdateShortcutKey);
            _dicCmd.Add("UpdateAccGroup", Commands.Command_UpdateAccGroup);
            _dicCmd.Add("UpdateAccTimeZone", Commands.Command_UpdateAccTimeZone);
            _dicCmd.Add("UpdateAccHoliday", Commands.Command_UpdateAccHoliday);
            _dicCmd.Add("UpdateAccUnLockComb", Commands.Command_UpdateAccUnLockComb);
            _dicCmd.Add("UpdateBlackList", Commands.Command_UpdateBlackList);
            cmbUpdate.Items.AddRange(new string[] { "UpdateUserInfo", "UpdateFingerTmp", "UpdateFaceTmp", "UpdateFvein"
                , "UpdateBioData", "UpdateUserPic", "UpdateSMS", "UpdateUserSMS", "UpdateAdPic", "UpdateWorkCode"
                , "UpdateShortcutKey", "UpdateAccGroup", "UpdateAccTimeZone", "UpdateAccHoliday", "UpdateAccUnLockComb", "UpdateBlackList"
            });

            //cmbDelete
            _dicCmd.Add("DeleteUser", Commands.Command_DeleteUser);
            _dicCmd.Add("DeleteFingerTmp1", Commands.Command_DeleteFingerTmp1);
            _dicCmd.Add("DeleteFingerTmp2", Commands.Command_DeleteFingerTmp2);
            _dicCmd.Add("DeleteFace", Commands.Command_DeleteFace);
            _dicCmd.Add("DeleteFvein1", Commands.Command_DeleteFvein1);
            _dicCmd.Add("DeleteFvein2", Commands.Command_DeleteFvein2);
            _dicCmd.Add("DeleteBioData1", Commands.Command_DeleteBioData1);
            _dicCmd.Add("DeleteBioData2", Commands.Command_DeleteBioData2);
            _dicCmd.Add("DeleteBioData3", Commands.Command_DeleteBioData3);
            _dicCmd.Add("DeleteUserPic", Commands.Command_DeleteUserPic);
            _dicCmd.Add("DeleteBioPhoto", Commands.Command_DeleteBioPhoto);
            _dicCmd.Add("DeleteSMS", Commands.Command_DeleteSMS);
            _dicCmd.Add("DeleteWorkCode", Commands.Command_DeleteWorkCode);
            _dicCmd.Add("DeleteAdPic", Commands.Command_DeleteAdPic);
            cmbDelete.Items.AddRange(new string[] { "DeleteUser", "DeleteFingerTmp1", "DeleteFingerTmp2" , "DeleteFace"
                , "DeleteFvein1", "DeleteFvein2", "DeleteBioData1", "DeleteBioData2", "DeleteBioData3", "DeleteUserPic"
                , "DeleteBioPhoto", "DeleteSMS", "DeleteWorkCode", "DeleteAdPic"
            });

            //cmbQuery
            _dicCmd.Add("QueryAttLog", Commands.Command_QueryAttLog);
            _dicCmd.Add("QueryAttPhoto", Commands.Command_QueryAttPhoto);
            _dicCmd.Add("QueryUserInfo", Commands.Command_QueryUserInfo);
            _dicCmd.Add("QueryFingerTmp", Commands.Command_QueryFingerTmp);
            _dicCmd.Add("QueryBioData1", Commands.Command_QueryBioData1);
            _dicCmd.Add("QueryBioData2", Commands.Command_QueryBioData2);
            _dicCmd.Add("QueryBioData3", Commands.Command_QueryBioData3);
            cmbQuery.Items.AddRange(new string[] { "QueryAttLog", "QueryAttPhoto", "QueryUserInfo", "QueryFingerTmp"
                , "QueryBioData1", "QueryBioData2", "QueryBioData3"
            });

            //cmbClear
            _dicCmd.Add("ClearLog", Commands.Command_ClearLog);
            _dicCmd.Add("ClearPhoto", Commands.Command_ClearPhoto);
            _dicCmd.Add("ClearData", Commands.Command_ClearData);
            _dicCmd.Add("ClearBioData", Commands.Command_ClearBioData);
            cmbClear.Items.AddRange(new string[] { "ClearLog", "ClearPhoto", "ClearData", "ClearBioData" });
        }

        private bool _isStart = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_isStart)
            {//Stop Server
                StopListenling();
                btnStart.Text = "Iniciar";
                btnStart.ForeColor = Color.FromArgb(37, 190, 167);
                // this.ucCommInfo1.AddCommInfo("", 4);
            }
            else
            {//Start Server
                StartListenling(cmbIP.Text, txtPort.Text);
                btnStart.Text = "Detener";
                btnStart.ForeColor = Color.Red;
                // this.ucCommInfo1.AddCommInfo("", 3);
            }
            _isStart = !_isStart;
        }

        private ListenClient listenClient = null;
        private Thread listenClientThread = null;

        private void StartListenling(string serverIP, string Port)
        {
            int port = string.IsNullOrEmpty(Port) ? 8085 : Int32.Parse(Port);
            listenClient = new ListenClient();
            listenClient.ServerIP = serverIP;
            listenClient.Port = port;
            listenClientThread = new Thread(new ThreadStart(listenClient.StartListening));
            listenClient.OnError += listenClient_OnError;
            listenClient.OnNewAttLog += listenClient_OnNewAttLog;
            listenClient.OnNewUser += listenClient_OnNewUser;
            listenClient.OnNewFP += listenClient_OnNewFP;
            listenClient.OnNewFace += listenClient_OnNewFace;
            listenClient.OnNewPalm += listenClient_OnNewPalm;
            listenClient.OnNewBioPhoto += listenClient_OnNewBioPhoto;
            listenClient.OnNewOpLog += listenClient_OnNewOpLog;
            listenClient.OnNewErrorLog += listenClient_OnNewErrorLog;
            listenClient.OnDeviceSync += listenClient_OnDeviceSync;
            listenClient.OnSendDataEvent += listenClient_OnSendDataEvent;
            listenClient.OnReceiveDataEvent += listenClient_OnReceiveDataEvent;
            listenClientThread.IsBackground = true;
            listenClientThread.Start();
        }

        private void StopListenling()
        {
            if (listenClient != null && listenClient.Listening)
            {
                listenClient.StopListening();
            }
        }
     
        #region Gestión de seguimiento de eventos

        private DeviceBll _deviceBll = null;
        private DeviceBll DeviceBll
        {
            get
            {
                if (_deviceBll == null)
                    _deviceBll = new DeviceBll();
                return _deviceBll;
            }
        }
        private AttLogBll _attLogBll = null;
        private AttLogBll AttLogBll
        {
            get
            {
                if (_attLogBll == null)
                    _attLogBll = new AttLogBll();
                return _attLogBll;
            }
        }
        private OpLogBll _opLogBll = null;
        private OpLogBll OpLogBll
        {
            get
            {
                if (_opLogBll == null)
                    _opLogBll = new OpLogBll();
                return _opLogBll;
            }
        }
        private ErrorLogBll _erLogBll = null;
        private ErrorLogBll ErLogBll
        {
            get
            {
                if (_erLogBll == null)
                    _erLogBll = new ErrorLogBll();
                return _erLogBll;
            }
        }


        private UserInfoBll _userInfoBll = null;
        private UserInfoBll UserInfoBll
        {
            get
            {
                if (_userInfoBll == null)
                    _userInfoBll = new UserInfoBll();
                return _userInfoBll;
            }
        }

        private TmpFPBll _fPBll = null;
        private TmpFPBll FPBll
        {
            get
            {
                if (_fPBll == null)
                    _fPBll = new TmpFPBll();
                return _fPBll;
            }
        }
        private TmpFaceBll _faceBll = null;
        private TmpFaceBll FaceBll
        {
            get
            {
                if (_faceBll == null)
                    _faceBll = new TmpFaceBll();
                return _faceBll;
            }
        }

        //private TmpBioData_CaraMtdBll _bioData_CaraMtdBll = null;
        //private TmpBioData_CaraMtdBll BioData_CaraMtdBll
        //{
        //    get
        //    {
        //        if (_bioData_CaraMtdBll == null)
        //            _bioData_CaraMtdBll = new TmpBioData_CaraMtdBll();
        //        return _bioData_CaraMtdBll;
        //    }
        //}

        private TmpBioDataBll _bioDataBll = null;
        private TmpBioDataBll BioDataBll
        {
            get
            {
                if (_bioDataBll == null)
                    _bioDataBll = new TmpBioDataBll();
                return _bioDataBll;
            }
        }
        private TmpBioPhotoBll _bioPhotoBll = null;
        private TmpBioPhotoBll BioPhotoBll
        {
            get
            {
                if (_bioPhotoBll == null)
                    _bioPhotoBll = new TmpBioPhotoBll();
                return _bioPhotoBll;
            }
        }

        private void listenClient_OnNewMachine(string sn)
        {
            DeviceModel machine = new DeviceModel();
            machine.DevSN = sn;
            machine.TimeZone = "34";
            if (DeviceBll.Add(machine) > 0)
            {
                // add device 
            }
        }

        //AttLog copy to Database 
        private void listenClient_OnNewAttLog(AttLogModel attlog)
        {
            if (AttLogBll.Add(attlog) > 0)
            {
                //if (_currentPageId == (int)PageIdEnum.Attendance && m_lastfrm != null)
                //{
                //    ((UCAttendance)m_lastfrm).AddNewRow(attlog);
                //}
                //else
                //{
                //    if (_currentPageId == (int)PageIdEnum.Device && m_lastfrm != null)
                //    {
                //        UCDevice.uCDevice = (UCDevice)m_lastfrm;
                //        uCDevice.UpdateDeviceMask(attlog.DeviceID, attlog.MaskFlag);
                //        uCDevice.UpdateDeviceTemp(attlog.DeviceID, attlog.Temperature);
                //    }
                //}

                UpdateDeviceMask(attlog.DeviceID, attlog.MaskFlag);
                UpdateDeviceTemp(attlog.DeviceID, attlog.Temperature);

            }
        }

        //OpLog copy to Database 
        private void listenClient_OnNewOpLog(OpLogModel oplog)
        {
            if (OpLogBll.Add(oplog) > 0)
            {
                ////add oplog 
                //if (_currentPageId == (int)PageIdEnum.DeviceOperationLog && m_lastfrm != null)
                //{
                //    UCOperateLog uCOperateLog = (UCOperateLog)m_lastfrm;
                //    uCOperateLog.RefreshData();
                //}                               
            }
        }
        //Error copy to Database 
        private void listenClient_OnNewErrorLog(ErrorLogModel erlog)
        {
            if (ErLogBll.Add(erlog) > 0)
            {
                ////add erlog 
                //if (_currentPageId == (int)PageIdEnum.ErrorLog && m_lastfrm != null)
                //{
                //    ((UCErrorLog)m_lastfrm).AddNewRow(erlog);
                //}
            }
        }
        //UserInfo copy to Database
        private void listenClient_OnNewUser(UserInfoModel user)
        {
            var userModel = UserInfoBll.Get(user.PIN);
            int nRtn = 0;
            if (null == userModel)
            {
                nRtn = _userInfoBll.Add(user);
            }
            else
            {
                nRtn = _userInfoBll.Update(user);
            }

            //// Revisar esta Verificacion //
            //if (nRtn > 0 && _currentPageId == (int)PageIdEnum.User && m_lastfrm != null)
            //{
            //    ((UCUser)m_lastfrm).LoadAllUsers();
            //}
        }

        private void listenClient_OnNewFP(TmpFPModel fp)
        {
            if (FPBll.Add(fp) > 0)
            {
                //if (_currentPageId == (int)PageIdEnum.User && m_lastfrm != null)
                //{
                //    if (fp.MajorVer == "9")
                //        ((UCUser)m_lastfrm).UpdateUserFP9Info(fp);
                //    else if (fp.MajorVer == "10")
                //        ((UCUser)m_lastfrm).UpdateUserFP10Info(fp);
                //}
            }
            
        }
        //Face tmplate copy to Database
        private void listenClient_OnNewFace(TmpFaceModel face)
        {
            if (FaceBll.Add(face) > 0)
            {
                //if (_currentPageId == (int)PageIdEnum.User && m_lastfrm != null)
                //{
                //    ((UCUser)m_lastfrm).UpdateUserFaceInfo(face);

                //}
            }

        }
        
        //palm tmplate copy to Database
        private void listenClient_OnNewPalm(TmpBioDataModel palm)
        {
            if (BioDataBll.Add(palm) > 0)
            {
                //if (_currentPageId == (int)PageIdEnum.User && m_lastfrm != null)
                //{
                //    ((UCUser)m_lastfrm).UpdateUserPalmInfo(palm);
                //}
            }

        }
        private void listenClient_OnNewBioPhoto(TmpBioPhotoModel bioPhoto)
        {
            if (BioPhotoBll.Add(bioPhoto) > 0)
            {
                //if (_currentPageId == (int)PageIdEnum.User && m_lastfrm != null)
                //{
                //    ((UCUser)m_lastfrm).UpdateUserFaceInfo(bioPhoto);
                //}
            }

        }
        //get vendor name
        private void listenClient_OnGetVendorName(string sn, string vendorName)
        {
            // update vendorName to gridview 
            DeviceBll.UpdateVendorName(sn, vendorName);
        }

        //Error Infor shows 
        private void listenClient_OnError(string errMessage)
        {
            if (errMessage.IndexOfEx("UnKnown message from device: POST /iclock/registry?") >= 0)
            {
                string sn = GetDevSN(errMessage);
                MessageBox.Show("有安防设备接入(SN=" + sn + ")，本服务仅支持考勤设备。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Log.WriteLogs(errMessage);
        }

        private string GetDevSN(string buffer)
        {
            string[] splitStr = buffer.Split('&', '?', ' ');
            if (splitStr.Length <= 0)
            {
                return null;
            }

            foreach (string tmpStr in splitStr)
            {
                if (tmpStr.IndexOfEx("SN=") >= 0)
                {
                    return tmpStr.Substring(tmpStr.IndexOfEx("SN=") + 3);
                }
            }
            return null;
        }

        //add Send data
        private void listenClient_OnSendDataEvent(string Data)
        {
            ////this.ucCommInfo1.AddCommInfo(Data, 1); 
        }

        //add receive data
        private void listenClient_OnReceiveDataEvent(string Data)
        {
            //this.ucCommInfo1.AddCommInfo(Data, 0);
        }

        //sync time
        private void listenClient_OnDeviceSync(DeviceModel device)
        {
            ////Update device
            //if (_currentPageId == (int)PageIdEnum.Device && m_lastfrm != null)
            //{
            //    UCDevice ucDevice = (UCDevice)m_lastfrm;
            //    ucDevice.UpdateDevice(device);
            //}

            UpdateDevice(device);
        }

        #endregion

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.dgvDevice.AutoGenerateColumns = false;
            LoadDevice();
            if (_dtDevice == null || _dtDevice.Rows.Count != 0)
            {
                foreach (DataRow dr in _dtDevice.Rows)
                {
                    string sn = dr["DevSN"].ToString();
                    int delay = Tools.TryConvertToInt32(dr["Delay"]);
                    if (!_dicDevInterval.ContainsKey(sn))
                    {
                        _dicDevInterval.Add(sn, 0);
                    }
                }
            }

            this.timerGetDevStatus.Enabled = true;
            this.timerGetDevStatus.Interval = 1000;

        }

        private void LoadDevice()
        {
            _dtDevice = _bll.GetAll("");
            this.dgvDevice.DataSource = _dtDevice;
        }

        private void timerGetDevStatus_Tick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < this.dgvDevice.Rows.Count; i++)
                {
                    string devSN = this.dgvDevice.Rows[i].Cells["colDevSN"].Value.ToString();
                    if (!_dicDevInterval.ContainsKey(devSN))
                        continue;

                    int devDelay = Tools.TryConvertToInt32(_dtDevice.Rows[i]["Delay"]);
                    if (devDelay > _dicDevInterval[devSN])
                    {
                        _dicDevInterval[devSN] += 1; //add 1s
                        continue;
                    }

                    _dicDevInterval[devSN] = 0; //reset
                    this.dgvDevice.Rows[i].Cells["colStatus"].Value = Properties.Resources.imgDevStatus1; //Set device off-line .Receive msg from device,set it on-line.
                }

            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.lblMsg.Visible = false;

            DeviceModel device = new DeviceModel();
            txtDevSN.Text = device.DevSN;
            txtDevName.Text = device.DevName;
            txtTransFlag.Text = device.TransFlag;
            cmbTimeZone.Text = device.TimeZone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDevSN.Text))
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Please input Device SN";
                return;
            }

            lblMsg.Visible = false;

            //Device Exsit,Update
            DeviceModel device;
            if (null != (device = _bll.Get(txtDevSN.Text.Trim())))
            {
                device.TimeZone = cmbTimeZone.Text;
                device.DevName = txtDevName.Text;
                device.TransFlag = txtTransFlag.Text.Trim();
                try
                {
                    if (_bll.Update(device) > 0)
                    {
                        LoadDevice();
                        lblMsg.Visible = true;
                        lblMsg.Text = "Update device success";
                    }
                    else
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Update device fail";
                    }
                    return;
                }
                catch { }
            }

            //Device No Exsit,Add
            lblMsg.Visible = false;
            device = new DeviceModel();
            device.DevSN = txtDevSN.Text.Trim();
            device.TimeZone = cmbTimeZone.Text;
            device.DevName = txtDevName.Text;
            device.TransFlag = txtTransFlag.Text.Trim();
            try
            {
                if (_bll.Add(device) > 0)
                {
                    LoadDevice();
                    if (!_dicDevInterval.ContainsKey(device.DevSN))
                    {
                        _dicDevInterval.Add(device.DevSN, 0);
                    }

                    lblMsg.Visible = true;
                    lblMsg.Text = "Add device SN " + txtDevSN.Text.Trim() + " success";
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Add device SN " + txtDevSN.Text.Trim() + " fail";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDevSN.Text))
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Please Input Device SN first";
                return;
            }
            string devSN = txtDevSN.Text.Trim();
            DeviceModel device;
            if (null == (device = _bll.Get(devSN)))
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Device SN is not exist";
                return;
            }
            lblMsg.Visible = false;

            if (_bll.Delete(devSN) > 0)
            {
                LoadDevice();
                _dicDevInterval.Remove(devSN);

                lblMsg.Visible = true;
                lblMsg.Text = "Remove device success";
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Remove device fail";
            }
        }

        private void dgvDevice_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            //Right-click to also select the row
            if (e.Button == MouseButtons.Right)
            {
                this.dgvDevice.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            }
            if (this.dgvDevice.CurrentRow == null)
                return;

            DataGridViewRow row = dgvDevice.CurrentRow;
            this.txtDevSN.Text = row.Cells["colDevSN"].Value.ToString();
            this.txtDevName.Text = row.Cells["colDevName"].Value.ToString();
            this.txtTransFlag.Text = row.Cells["colTransFlag"].Value.ToString();
            this.cmbTimeZone.Text = row.Cells["colTimeZone"].Value.ToString();

            //Asignacion de variable _devSN para los Comandos
            _devSN = row.Cells["colDevSN"].Value.ToString();
        }

        public void UpdateDeviceMask(string devSN, int maskStatus)
        {
            for (int i = 0; i < this.dgvDevice.Rows.Count; i++)
            {
                string sn = this.dgvDevice.Rows[i].Cells["colDevSN"].Value.ToString();
                if (devSN != sn)
                    continue;

                string maskDesc = "";
                switch (maskStatus)
                {
                    case 0:
                        maskDesc = "No";
                        break;
                    case 1:
                        maskDesc = "Yes";
                        break;
                    case 2:
                        maskDesc = "";
                        break;
                    default:
                        break;
                }

                this.dgvDevice.Rows[i].Cells["colMask"].Value = maskDesc;
            }
        }

        public void UpdateDeviceTemp(string devSN, string tempVal)
        {
            for (int i = 0; i < this.dgvDevice.Rows.Count; i++)
            {
                string sn = this.dgvDevice.Rows[i].Cells["colDevSN"].Value.ToString();
                if (devSN != sn)
                    continue;

                tempVal = (string.IsNullOrEmpty(tempVal)) ? "Disable/NotFound" : tempVal;

                this.dgvDevice.Rows[i].Cells["colTemp"].Value = tempVal;
            }
        }

        public string devSN;

        public void UpdateDevice(DeviceModel dev)
        {
            for (int i = 0; i < this.dgvDevice.Rows.Count; i++)
            {
                //devSN = this.dgvDevice.Rows[i].Cells["colDevSN"].Value.ToString();
                string devSN = this.dgvDevice.Rows[i].Cells["colDevSN"].Value.ToString();
                if (dev.DevSN != devSN)
                    continue;

                this.dgvDevice.Rows[i].Cells["colStatus"].Value = Properties.Resources.imgDevStatus2; //Set device on-line.
                this.dgvDevice.Rows[i].Cells["colDevIP"].Value = dev.DevIP;
                if (_dicDevInterval.ContainsKey(devSN))
                {
                    _dicDevInterval[devSN] = 0;
                }

                this.dgvDevice.Rows[i].Cells["colDevIP"].Value = dev.DevIP;
                this.dgvDevice.Rows[i].Cells["colFirmwareVersion"].Value = dev.DevFirmwareVersion;
            }

            // lstDevMsgDevice.Refresh();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_devSN))
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Please select a device";
                return;
            }

            if (string.IsNullOrEmpty(rtxtCmd.Text))
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Cmd content is empty";
                return;
            }

            if (!CheckCmd(rtxtCmd.Text))
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Cmd content is invalid";
                return;
            }

            /// ESTO DEBE VENIR POR ACA

            DeviceCmdModel model = new DeviceCmdModel();
            model.DevSN = devSN;
            model.Content = rtxtCmd.Text;
            model.CommitTime = Tools.GetDateTimeNow();

            if (_bll.Add() > 0)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Success";
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Fail";
            }

        }

        private bool CheckCmd(string cmd)
        {
            //检查是否包含符号 “{”，“}”      /// Compruebe si contiene los símbolos "{", "}"
            if (cmd.IndexOf('{') >= 0)
                return false;
            if (cmd.IndexOf('}') >= 0)
                return false;

            return true;
        }


        #region ComboBoxSelectedIndexChanged 

        private void GetCmdContent(ComboBox cmb)
        {
            if (cmb.SelectedIndex < 0)
                return;

            string cmdName = cmb.SelectedItem.ToString();
            if (_dicCmd.ContainsKey(cmdName))
                rtxtCmd.Text = _dicCmd[cmdName];
            else
                rtxtCmd.Text = "";
        }

        private void cmbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCmdContent((ComboBox)sender);
        }

        private void cmbUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCmdContent((ComboBox)sender);
        }

        private void cmbDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCmdContent((ComboBox)sender);
        }

        private void cmbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCmdContent((ComboBox)sender);
        }

        private void cmbClear_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCmdContent((ComboBox)sender);
        }

        private void rbtnUserDefined_CheckedChanged(object sender, EventArgs e)
        {
            DisableCombobox();
            this.rtxtCmd.Text = "";
        }

        private void rbtnClear_CheckedChanged(object sender, EventArgs e)
        {
            DisableCombobox();
            this.cmbClear.Enabled = true;
        }

        private void rbtnQuery_CheckedChanged(object sender, EventArgs e)
        {
            DisableCombobox();
            this.cmbQuery.Enabled = true;
        }

        private void rbtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            DisableCombobox();
            this.cmbDelete.Enabled = true;
        }

        private void rbtnUpdate_CheckedChanged(object sender, EventArgs e)
        {
            DisableCombobox();
            this.cmbUpdate.Enabled = true;
        }

        private void rbtnControl_CheckedChanged(object sender, EventArgs e)
        {
            DisableCombobox();
            this.cmbControl.Enabled = true;
        }

        private void DisableCombobox()
        {
            this.cmbControl.Enabled = false;
            this.cmbUpdate.Enabled = false;
            this.cmbDelete.Enabled = false;
            this.cmbQuery.Enabled = false;
            this.cmbClear.Enabled = false;
        }

        #endregion end-ComboBoxSelectedIndexChanged 

    }

}
