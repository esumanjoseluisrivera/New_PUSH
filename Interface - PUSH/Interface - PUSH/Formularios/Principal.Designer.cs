
namespace Interface___PUSH
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.cmbIP = new System.Windows.Forms.ComboBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.colStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDevSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDevName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDevIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirmwareVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtTransFlag = new System.Windows.Forms.TextBox();
            this.lblTransFlag = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbTimeZone = new System.Windows.Forms.ComboBox();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDevName = new System.Windows.Forms.TextBox();
            this.lblDevName = new System.Windows.Forms.Label();
            this.lblDevSN = new System.Windows.Forms.Label();
            this.txtDevSN = new System.Windows.Forms.TextBox();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.timerGetDevStatus = new System.Windows.Forms.Timer(this.components);
            this.rbtnUserDefined = new System.Windows.Forms.RadioButton();
            this.cmbControl = new System.Windows.Forms.ComboBox();
            this.cmbClear = new System.Windows.Forms.ComboBox();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.rbtnDelete = new System.Windows.Forms.RadioButton();
            this.rbtnQuery = new System.Windows.Forms.RadioButton();
            this.rbtnClear = new System.Windows.Forms.RadioButton();
            this.rbtnControl = new System.Windows.Forms.RadioButton();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.rbtnUpdate = new System.Windows.Forms.RadioButton();
            this.rtxtCmd = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(138, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 28);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Arial", 9F);
            this.txtPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPort.Location = new System.Drawing.Point(138, 54);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(121, 21);
            this.txtPort.TabIndex = 8;
            this.txtPort.Text = "8085";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPort.Location = new System.Drawing.Point(102, 56);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 16);
            this.lblPort.TabIndex = 7;
            this.lblPort.Text = "Port";
            // 
            // cmbIP
            // 
            this.cmbIP.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbIP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbIP.FormattingEnabled = true;
            this.cmbIP.Location = new System.Drawing.Point(138, 27);
            this.cmbIP.Name = "cmbIP";
            this.cmbIP.Size = new System.Drawing.Size(121, 23);
            this.cmbIP.TabIndex = 6;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Arial", 10F);
            this.lblIP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIP.Location = new System.Drawing.Point(102, 30);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 16);
            this.lblIP.TabIndex = 5;
            this.lblIP.Text = "IP";
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.AllowUserToResizeRows = false;
            this.dgvDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStatus,
            this.colDevSN,
            this.colDevName,
            this.colMask,
            this.colTemp,
            this.colDevIP,
            this.colFirmwareVersion,
            this.colTransFlag,
            this.colTimeZone});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevice.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDevice.Location = new System.Drawing.Point(356, 65);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(612, 384);
            this.dgvDevice.TabIndex = 10;
            this.dgvDevice.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDevice_CellMouseClick);
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStatus.Frozen = true;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Image = global::Interface___PUSH.Properties.Resources.imgDevStatus1;
            this.colStatus.MinimumWidth = 70;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 70;
            // 
            // colDevSN
            // 
            this.colDevSN.DataPropertyName = "DevSN";
            this.colDevSN.HeaderText = "DeviceSN";
            this.colDevSN.Name = "colDevSN";
            this.colDevSN.ReadOnly = true;
            this.colDevSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDevName
            // 
            this.colDevName.DataPropertyName = "DevName";
            this.colDevName.HeaderText = "DeviceName";
            this.colDevName.Name = "colDevName";
            this.colDevName.ReadOnly = true;
            // 
            // colMask
            // 
            this.colMask.HeaderText = "Mask";
            this.colMask.Name = "colMask";
            this.colMask.ReadOnly = true;
            this.colMask.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTemp
            // 
            this.colTemp.HeaderText = "Temperature";
            this.colTemp.Name = "colTemp";
            this.colTemp.ReadOnly = true;
            this.colTemp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDevIP
            // 
            this.colDevIP.DataPropertyName = "DevIP";
            this.colDevIP.HeaderText = "DeviceIP";
            this.colDevIP.Name = "colDevIP";
            this.colDevIP.ReadOnly = true;
            this.colDevIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFirmwareVersion
            // 
            this.colFirmwareVersion.DataPropertyName = "DevFirmwareVersion";
            this.colFirmwareVersion.HeaderText = "FirmwareVersion";
            this.colFirmwareVersion.Name = "colFirmwareVersion";
            this.colFirmwareVersion.ReadOnly = true;
            this.colFirmwareVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTransFlag
            // 
            this.colTransFlag.DataPropertyName = "TransFlag";
            this.colTransFlag.HeaderText = "TransFlag";
            this.colTransFlag.Name = "colTransFlag";
            this.colTransFlag.ReadOnly = true;
            this.colTransFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTransFlag.Visible = false;
            // 
            // colTimeZone
            // 
            this.colTimeZone.DataPropertyName = "TimeZone";
            this.colTimeZone.HeaderText = "TimeZone";
            this.colTimeZone.Name = "colTimeZone";
            this.colTimeZone.ReadOnly = true;
            this.colTimeZone.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMsg.Location = new System.Drawing.Point(13, 171);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(23, 12);
            this.lblMsg.TabIndex = 44;
            this.lblMsg.Text = "msg";
            this.lblMsg.Visible = false;
            // 
            // txtTransFlag
            // 
            this.txtTransFlag.Font = new System.Drawing.Font("Arial", 9F);
            this.txtTransFlag.Location = new System.Drawing.Point(91, 329);
            this.txtTransFlag.Name = "txtTransFlag";
            this.txtTransFlag.Size = new System.Drawing.Size(216, 21);
            this.txtTransFlag.TabIndex = 43;
            // 
            // lblTransFlag
            // 
            this.lblTransFlag.AutoSize = true;
            this.lblTransFlag.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTransFlag.Location = new System.Drawing.Point(12, 331);
            this.lblTransFlag.Name = "lblTransFlag";
            this.lblTransFlag.Size = new System.Drawing.Size(67, 16);
            this.lblTransFlag.TabIndex = 42;
            this.lblTransFlag.Text = "Transflag";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Firebrick;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.Location = new System.Drawing.Point(15, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 33);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Nuevo";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.Location = new System.Drawing.Point(227, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 33);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbTimeZone
            // 
            this.cmbTimeZone.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbTimeZone.FormattingEnabled = true;
            this.cmbTimeZone.Items.AddRange(new object[] {
            "-12:30",
            "-12:00",
            "-11:30",
            "-11:00",
            "-10:30",
            "-10:00",
            "-09:30",
            "-09:00",
            "-08:30",
            "-08:00",
            "-07:30",
            "-07:00",
            "-06:30",
            "-06:00",
            "-05:30",
            "-05:00",
            "-04:30",
            "-04:00",
            "-03:30",
            "-03:00",
            "-02:30",
            "-02:00",
            "-01:30",
            "-01:00",
            "-00:30",
            "",
            "+00:30",
            "+01:00",
            "+01:30",
            "+02:00",
            "+02:30",
            "+03:00",
            "+03:30",
            "+04:00",
            "+04:30",
            "+05:00",
            "+05:30",
            "+06:00",
            "+06:30",
            "+07:00",
            "+07:30",
            "+08:00",
            "+08:30",
            "+09:00",
            "+09:30",
            "+10:00",
            "+10:30",
            "+11:00",
            "+11:30",
            "+12:00",
            "+12:30",
            "+13:00",
            "+13:30"});
            this.cmbTimeZone.Location = new System.Drawing.Point(91, 295);
            this.cmbTimeZone.Name = "cmbTimeZone";
            this.cmbTimeZone.Size = new System.Drawing.Size(216, 23);
            this.cmbTimeZone.TabIndex = 39;
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.AutoSize = true;
            this.lblTimeZone.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTimeZone.Location = new System.Drawing.Point(12, 298);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(70, 16);
            this.lblTimeZone.TabIndex = 38;
            this.lblTimeZone.Text = "TimeZone";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Firebrick;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageIndex = 4;
            this.btnSave.Location = new System.Drawing.Point(121, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 33);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDevName
            // 
            this.txtDevName.Font = new System.Drawing.Font("Arial", 9F);
            this.txtDevName.Location = new System.Drawing.Point(91, 264);
            this.txtDevName.Name = "txtDevName";
            this.txtDevName.Size = new System.Drawing.Size(216, 21);
            this.txtDevName.TabIndex = 36;
            // 
            // lblDevName
            // 
            this.lblDevName.AutoSize = true;
            this.lblDevName.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDevName.Location = new System.Drawing.Point(12, 266);
            this.lblDevName.Name = "lblDevName";
            this.lblDevName.Size = new System.Drawing.Size(44, 16);
            this.lblDevName.TabIndex = 35;
            this.lblDevName.Text = "Name";
            // 
            // lblDevSN
            // 
            this.lblDevSN.AutoSize = true;
            this.lblDevSN.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDevSN.Location = new System.Drawing.Point(12, 233);
            this.lblDevSN.Name = "lblDevSN";
            this.lblDevSN.Size = new System.Drawing.Size(26, 16);
            this.lblDevSN.TabIndex = 34;
            this.lblDevSN.Text = "SN";
            // 
            // txtDevSN
            // 
            this.txtDevSN.Font = new System.Drawing.Font("Arial", 9F);
            this.txtDevSN.Location = new System.Drawing.Point(91, 231);
            this.txtDevSN.Name = "txtDevSN";
            this.txtDevSN.Size = new System.Drawing.Size(216, 21);
            this.txtDevSN.TabIndex = 33;
            // 
            // cmdLoad
            // 
            this.cmdLoad.BackColor = System.Drawing.Color.Firebrick;
            this.cmdLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLoad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLoad.Font = new System.Drawing.Font("Arial", 12F);
            this.cmdLoad.ForeColor = System.Drawing.Color.White;
            this.cmdLoad.ImageIndex = 2;
            this.cmdLoad.Location = new System.Drawing.Point(356, 21);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(87, 33);
            this.cmdLoad.TabIndex = 45;
            this.cmdLoad.Text = "Cargar";
            this.cmdLoad.UseVisualStyleBackColor = false;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // timerGetDevStatus
            // 
            this.timerGetDevStatus.Interval = 1000;
            this.timerGetDevStatus.Tick += new System.EventHandler(this.timerGetDevStatus_Tick);
            // 
            // rbtnUserDefined
            // 
            this.rbtnUserDefined.AutoSize = true;
            this.rbtnUserDefined.Font = new System.Drawing.Font("Arial", 10F);
            this.rbtnUserDefined.Location = new System.Drawing.Point(1015, 219);
            this.rbtnUserDefined.Name = "rbtnUserDefined";
            this.rbtnUserDefined.Size = new System.Drawing.Size(109, 20);
            this.rbtnUserDefined.TabIndex = 84;
            this.rbtnUserDefined.TabStop = true;
            this.rbtnUserDefined.Text = "User-Defined";
            this.rbtnUserDefined.UseVisualStyleBackColor = true;
            this.rbtnUserDefined.CheckedChanged += new System.EventHandler(this.rbtnUserDefined_CheckedChanged);
            // 
            // cmbControl
            // 
            this.cmbControl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbControl.FormattingEnabled = true;
            this.cmbControl.Location = new System.Drawing.Point(1085, 69);
            this.cmbControl.Name = "cmbControl";
            this.cmbControl.Size = new System.Drawing.Size(153, 20);
            this.cmbControl.TabIndex = 83;
            this.cmbControl.SelectedIndexChanged += new System.EventHandler(this.cmbControl_SelectedIndexChanged);
            // 
            // cmbClear
            // 
            this.cmbClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbClear.FormattingEnabled = true;
            this.cmbClear.Location = new System.Drawing.Point(1085, 173);
            this.cmbClear.Name = "cmbClear";
            this.cmbClear.Size = new System.Drawing.Size(153, 20);
            this.cmbClear.TabIndex = 82;
            this.cmbClear.SelectedIndexChanged += new System.EventHandler(this.cmbClear_SelectedIndexChanged);
            // 
            // cmbQuery
            // 
            this.cmbQuery.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQuery.FormattingEnabled = true;
            this.cmbQuery.Location = new System.Drawing.Point(1085, 147);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(153, 20);
            this.cmbQuery.TabIndex = 81;
            this.cmbQuery.SelectedIndexChanged += new System.EventHandler(this.cmbQuery_SelectedIndexChanged);
            // 
            // cmbDelete
            // 
            this.cmbDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(1085, 121);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(153, 20);
            this.cmbDelete.TabIndex = 80;
            this.cmbDelete.SelectedIndexChanged += new System.EventHandler(this.cmbDelete_SelectedIndexChanged);
            // 
            // rbtnDelete
            // 
            this.rbtnDelete.AutoSize = true;
            this.rbtnDelete.Font = new System.Drawing.Font("Arial", 10F);
            this.rbtnDelete.Location = new System.Drawing.Point(1015, 121);
            this.rbtnDelete.Name = "rbtnDelete";
            this.rbtnDelete.Size = new System.Drawing.Size(67, 20);
            this.rbtnDelete.TabIndex = 79;
            this.rbtnDelete.TabStop = true;
            this.rbtnDelete.Text = "Delete";
            this.rbtnDelete.UseVisualStyleBackColor = true;
            this.rbtnDelete.CheckedChanged += new System.EventHandler(this.rbtnDelete_CheckedChanged);
            // 
            // rbtnQuery
            // 
            this.rbtnQuery.AutoSize = true;
            this.rbtnQuery.Font = new System.Drawing.Font("Arial", 10F);
            this.rbtnQuery.Location = new System.Drawing.Point(1015, 147);
            this.rbtnQuery.Name = "rbtnQuery";
            this.rbtnQuery.Size = new System.Drawing.Size(65, 20);
            this.rbtnQuery.TabIndex = 78;
            this.rbtnQuery.TabStop = true;
            this.rbtnQuery.Text = "Query";
            this.rbtnQuery.UseVisualStyleBackColor = true;
            this.rbtnQuery.CheckedChanged += new System.EventHandler(this.rbtnQuery_CheckedChanged);
            // 
            // rbtnClear
            // 
            this.rbtnClear.AutoSize = true;
            this.rbtnClear.Font = new System.Drawing.Font("Arial", 10F);
            this.rbtnClear.Location = new System.Drawing.Point(1015, 173);
            this.rbtnClear.Name = "rbtnClear";
            this.rbtnClear.Size = new System.Drawing.Size(60, 20);
            this.rbtnClear.TabIndex = 77;
            this.rbtnClear.TabStop = true;
            this.rbtnClear.Text = "Clear";
            this.rbtnClear.UseVisualStyleBackColor = true;
            this.rbtnClear.CheckedChanged += new System.EventHandler(this.rbtnClear_CheckedChanged);
            // 
            // rbtnControl
            // 
            this.rbtnControl.AutoSize = true;
            this.rbtnControl.Font = new System.Drawing.Font("Arial", 10F);
            this.rbtnControl.Location = new System.Drawing.Point(1015, 69);
            this.rbtnControl.Name = "rbtnControl";
            this.rbtnControl.Size = new System.Drawing.Size(72, 20);
            this.rbtnControl.TabIndex = 76;
            this.rbtnControl.TabStop = true;
            this.rbtnControl.Text = "Control";
            this.rbtnControl.UseVisualStyleBackColor = true;
            this.rbtnControl.CheckedChanged += new System.EventHandler(this.rbtnControl_CheckedChanged);
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(1085, 95);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(153, 20);
            this.cmbUpdate.TabIndex = 75;
            this.cmbUpdate.SelectedIndexChanged += new System.EventHandler(this.cmbUpdate_SelectedIndexChanged);
            // 
            // rbtnUpdate
            // 
            this.rbtnUpdate.AutoSize = true;
            this.rbtnUpdate.Font = new System.Drawing.Font("Arial", 10F);
            this.rbtnUpdate.Location = new System.Drawing.Point(1015, 95);
            this.rbtnUpdate.Name = "rbtnUpdate";
            this.rbtnUpdate.Size = new System.Drawing.Size(71, 20);
            this.rbtnUpdate.TabIndex = 74;
            this.rbtnUpdate.TabStop = true;
            this.rbtnUpdate.Text = "Update";
            this.rbtnUpdate.UseVisualStyleBackColor = true;
            this.rbtnUpdate.CheckedChanged += new System.EventHandler(this.rbtnUpdate_CheckedChanged);
            // 
            // rtxtCmd
            // 
            this.rtxtCmd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxtCmd.Location = new System.Drawing.Point(1015, 245);
            this.rtxtCmd.Name = "rtxtCmd";
            this.rtxtCmd.Size = new System.Drawing.Size(268, 169);
            this.rtxtCmd.TabIndex = 88;
            this.rtxtCmd.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(1174, 430);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 32);
            this.btnCreate.TabIndex = 87;
            this.btnCreate.Text = "Ejecutar";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 491);
            this.Controls.Add(this.rtxtCmd);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rbtnUserDefined);
            this.Controls.Add(this.cmbControl);
            this.Controls.Add(this.cmbClear);
            this.Controls.Add(this.cmbQuery);
            this.Controls.Add(this.cmbDelete);
            this.Controls.Add(this.rbtnDelete);
            this.Controls.Add(this.rbtnQuery);
            this.Controls.Add(this.rbtnClear);
            this.Controls.Add(this.rbtnControl);
            this.Controls.Add(this.cmbUpdate);
            this.Controls.Add(this.rbtnUpdate);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtTransFlag);
            this.Controls.Add(this.lblTransFlag);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbTimeZone);
            this.Controls.Add(this.lblTimeZone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDevName);
            this.Controls.Add(this.lblDevName);
            this.Controls.Add(this.lblDevSN);
            this.Controls.Add(this.txtDevSN);
            this.Controls.Add(this.dgvDevice);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cmbIP);
            this.Controls.Add(this.lblIP);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cmbIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtTransFlag;
        private System.Windows.Forms.Label lblTransFlag;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbTimeZone;
        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDevName;
        private System.Windows.Forms.Label lblDevName;
        private System.Windows.Forms.Label lblDevSN;
        private System.Windows.Forms.TextBox txtDevSN;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Timer timerGetDevStatus;
        private System.Windows.Forms.DataGridViewImageColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDevSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDevName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDevIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirmwareVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeZone;
        private System.Windows.Forms.RadioButton rbtnUserDefined;
        private System.Windows.Forms.ComboBox cmbControl;
        private System.Windows.Forms.ComboBox cmbClear;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.ComboBox cmbDelete;
        private System.Windows.Forms.RadioButton rbtnDelete;
        private System.Windows.Forms.RadioButton rbtnQuery;
        private System.Windows.Forms.RadioButton rbtnClear;
        private System.Windows.Forms.RadioButton rbtnControl;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.RadioButton rbtnUpdate;
        private System.Windows.Forms.RichTextBox rtxtCmd;
        private System.Windows.Forms.Button btnCreate;
    }
}

