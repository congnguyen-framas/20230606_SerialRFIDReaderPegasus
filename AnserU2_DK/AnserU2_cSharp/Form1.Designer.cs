
namespace AnserU2_cSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._ccbComPort = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this._labEmpId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _ccbComPort
            // 
            this._ccbComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ccbComPort.FormattingEnabled = true;
            this._ccbComPort.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this._ccbComPort.Location = new System.Drawing.Point(116, 37);
            this._ccbComPort.Margin = new System.Windows.Forms.Padding(2);
            this._ccbComPort.Name = "_ccbComPort";
            this._ccbComPort.Size = new System.Drawing.Size(92, 24);
            this._ccbComPort.TabIndex = 18;
            // 
            // btn_connect
            // 
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Location = new System.Drawing.Point(229, 35);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(92, 28);
            this.btn_connect.TabIndex = 15;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // _labEmpId
            // 
            this._labEmpId.Cursor = System.Windows.Forms.Cursors.Default;
            this._labEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labEmpId.Location = new System.Drawing.Point(13, 84);
            this._labEmpId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labEmpId.Name = "_labEmpId";
            this._labEmpId.Size = new System.Drawing.Size(776, 84);
            this._labEmpId.TabIndex = 28;
            this._labEmpId.Text = "Status:";
            this._labEmpId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ComPort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._labEmpId);
            this.Controls.Add(this._ccbComPort);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ComboBox _ccbComPort;
        internal System.Windows.Forms.Button btn_connect;
        internal System.Windows.Forms.Label _labEmpId;
        private System.Windows.Forms.Label label1;
    }
}

