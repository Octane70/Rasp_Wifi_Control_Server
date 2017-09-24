namespace RaspberryCar
{
    partial class MainForm
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
            this.btnDe = new System.Windows.Forms.Button();
            this.txtIPAdress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stsConnect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDe
            // 
            this.btnDe.Location = new System.Drawing.Point(22, 161);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(99, 55);
            this.btnDe.TabIndex = 0;
            this.btnDe.Text = "Decrease";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // txtIPAdress
            // 
            this.txtIPAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAdress.Location = new System.Drawing.Point(22, 22);
            this.txtIPAdress.Multiline = true;
            this.txtIPAdress.Name = "txtIPAdress";
            this.txtIPAdress.Size = new System.Drawing.Size(157, 37);
            this.txtIPAdress.TabIndex = 1;
            this.txtIPAdress.Text = "192.168.1.28";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(299, 22);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 37);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(20, 89);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(101, 55);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "Increase";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(186, 22);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(84, 37);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "21567";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Connection:";
            // 
            // stsConnect
            // 
            this.stsConnect.AutoSize = true;
            this.stsConnect.Location = new System.Drawing.Point(111, 66);
            this.stsConnect.Name = "stsConnect";
            this.stsConnect.Size = new System.Drawing.Size(0, 17);
            this.stsConnect.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 241);
            this.Controls.Add(this.stsConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIPAdress);
            this.Controls.Add(this.btnDe);
            this.Name = "MainForm";
            this.Text = "RaspberryCar Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.TextBox txtIPAdress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stsConnect;
    }
}

