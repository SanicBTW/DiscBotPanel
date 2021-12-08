namespace DiscordBotTest
{
    partial class BotPowerForm
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
            this.StartBotBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShutdownBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DelTokenBTN = new System.Windows.Forms.Button();
            this.SaveTokenBTN = new System.Windows.Forms.Button();
            this.TokenTXTBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBotBTN
            // 
            this.StartBotBTN.Location = new System.Drawing.Point(6, 22);
            this.StartBotBTN.Name = "StartBotBTN";
            this.StartBotBTN.Size = new System.Drawing.Size(75, 23);
            this.StartBotBTN.TabIndex = 0;
            this.StartBotBTN.Text = "Start Bot";
            this.StartBotBTN.UseVisualStyleBackColor = true;
            this.StartBotBTN.Click += new System.EventHandler(this.StartBotBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShutdownBTN);
            this.groupBox1.Controls.Add(this.StartBotBTN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Power Options";
            // 
            // ShutdownBTN
            // 
            this.ShutdownBTN.Location = new System.Drawing.Point(87, 22);
            this.ShutdownBTN.Name = "ShutdownBTN";
            this.ShutdownBTN.Size = new System.Drawing.Size(91, 23);
            this.ShutdownBTN.TabIndex = 1;
            this.ShutdownBTN.Text = "Shutdown Bot";
            this.ShutdownBTN.UseVisualStyleBackColor = true;
            this.ShutdownBTN.Click += new System.EventHandler(this.ShutdownBTN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DelTokenBTN);
            this.groupBox2.Controls.Add(this.SaveTokenBTN);
            this.groupBox2.Controls.Add(this.TokenTXTBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Token";
            // 
            // DelTokenBTN
            // 
            this.DelTokenBTN.Location = new System.Drawing.Point(88, 51);
            this.DelTokenBTN.Name = "DelTokenBTN";
            this.DelTokenBTN.Size = new System.Drawing.Size(91, 23);
            this.DelTokenBTN.TabIndex = 3;
            this.DelTokenBTN.Text = "Delete Token";
            this.DelTokenBTN.UseVisualStyleBackColor = true;
            this.DelTokenBTN.Click += new System.EventHandler(this.DelTokenBTN_Click);
            // 
            // SaveTokenBTN
            // 
            this.SaveTokenBTN.Location = new System.Drawing.Point(7, 51);
            this.SaveTokenBTN.Name = "SaveTokenBTN";
            this.SaveTokenBTN.Size = new System.Drawing.Size(75, 23);
            this.SaveTokenBTN.TabIndex = 2;
            this.SaveTokenBTN.Text = "Save Token";
            this.SaveTokenBTN.UseVisualStyleBackColor = true;
            this.SaveTokenBTN.Click += new System.EventHandler(this.SaveTokenBTN_Click);
            // 
            // TokenTXTBox
            // 
            this.TokenTXTBox.Location = new System.Drawing.Point(7, 22);
            this.TokenTXTBox.Name = "TokenTXTBox";
            this.TokenTXTBox.Size = new System.Drawing.Size(334, 23);
            this.TokenTXTBox.TabIndex = 1;
            // 
            // BotPowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 161);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BotPowerForm";
            this.Text = "BotPowerForm";
            this.Load += new System.EventHandler(this.BotPowerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBotBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ShutdownBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DelTokenBTN;
        private System.Windows.Forms.Button SaveTokenBTN;
        private System.Windows.Forms.TextBox TokenTXTBox;
    }
}