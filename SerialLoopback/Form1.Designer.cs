namespace SerialLoopback
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.port2Cbx = new System.Windows.Forms.ComboBox();
            this.baudCbx = new System.Windows.Forms.ComboBox();
            this.parityCbx = new System.Windows.Forms.ComboBox();
            this.databitsCbx = new System.Windows.Forms.ComboBox();
            this.stopBitsCbx = new System.Windows.Forms.ComboBox();
            this.handShakeCbx = new System.Windows.Forms.ComboBox();
            this.port1Cbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stop Bits:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Handshake:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Port Name 2:";
            // 
            // port2Cbx
            // 
            this.port2Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port2Cbx.FormattingEnabled = true;
            this.port2Cbx.Location = new System.Drawing.Point(79, 70);
            this.port2Cbx.Name = "port2Cbx";
            this.port2Cbx.Size = new System.Drawing.Size(194, 21);
            this.port2Cbx.TabIndex = 8;
            // 
            // baudCbx
            // 
            this.baudCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudCbx.FormattingEnabled = true;
            this.baudCbx.Location = new System.Drawing.Point(78, 115);
            this.baudCbx.Name = "baudCbx";
            this.baudCbx.Size = new System.Drawing.Size(194, 21);
            this.baudCbx.TabIndex = 9;
            // 
            // parityCbx
            // 
            this.parityCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityCbx.FormattingEnabled = true;
            this.parityCbx.Location = new System.Drawing.Point(78, 160);
            this.parityCbx.Name = "parityCbx";
            this.parityCbx.Size = new System.Drawing.Size(194, 21);
            this.parityCbx.TabIndex = 10;
            // 
            // databitsCbx
            // 
            this.databitsCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databitsCbx.FormattingEnabled = true;
            this.databitsCbx.Location = new System.Drawing.Point(79, 205);
            this.databitsCbx.Name = "databitsCbx";
            this.databitsCbx.Size = new System.Drawing.Size(194, 21);
            this.databitsCbx.TabIndex = 11;
            // 
            // stopBitsCbx
            // 
            this.stopBitsCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsCbx.FormattingEnabled = true;
            this.stopBitsCbx.Location = new System.Drawing.Point(78, 250);
            this.stopBitsCbx.Name = "stopBitsCbx";
            this.stopBitsCbx.Size = new System.Drawing.Size(194, 21);
            this.stopBitsCbx.TabIndex = 12;
            // 
            // handShakeCbx
            // 
            this.handShakeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.handShakeCbx.FormattingEnabled = true;
            this.handShakeCbx.Location = new System.Drawing.Point(78, 295);
            this.handShakeCbx.Name = "handShakeCbx";
            this.handShakeCbx.Size = new System.Drawing.Size(194, 21);
            this.handShakeCbx.TabIndex = 13;
            // 
            // port1Cbx
            // 
            this.port1Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port1Cbx.FormattingEnabled = true;
            this.port1Cbx.Location = new System.Drawing.Point(78, 25);
            this.port1Cbx.Name = "port1Cbx";
            this.port1Cbx.Size = new System.Drawing.Size(194, 21);
            this.port1Cbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Name 1:";
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(153, 363);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(119, 23);
            this.startStopBtn.TabIndex = 14;
            this.startStopBtn.Text = "Connect";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 421);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.handShakeCbx);
            this.Controls.Add(this.stopBitsCbx);
            this.Controls.Add(this.databitsCbx);
            this.Controls.Add(this.parityCbx);
            this.Controls.Add(this.baudCbx);
            this.Controls.Add(this.port2Cbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port1Cbx);
            this.MaximumSize = new System.Drawing.Size(300, 459);
            this.Name = "Form1";
            this.Text = "Serial Loopback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox port2Cbx;
        private System.Windows.Forms.ComboBox baudCbx;
        private System.Windows.Forms.ComboBox parityCbx;
        private System.Windows.Forms.ComboBox databitsCbx;
        private System.Windows.Forms.ComboBox stopBitsCbx;
        private System.Windows.Forms.ComboBox handShakeCbx;
        private System.Windows.Forms.ComboBox port1Cbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startStopBtn;

    }
}

