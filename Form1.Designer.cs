namespace Twitch_Watcher
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptfenster));
            this.Username_textbox = new System.Windows.Forms.TextBox();
            this.Testbutton = new System.Windows.Forms.Button();
            this.Videofenster = new System.Windows.Forms.WebBrowser();
            this.Chatfenster = new System.Windows.Forms.WebBrowser();
            this.Nametag = new System.Windows.Forms.Label();
            this.hidechatbt = new System.Windows.Forms.Button();
            this.Viewercounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_textbox
            // 
            this.Username_textbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username_textbox.Location = new System.Drawing.Point(12, 12);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(235, 20);
            this.Username_textbox.TabIndex = 0;
            this.Username_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_textbox_KeyPress);
            // 
            // Testbutton
            // 
            this.Testbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Testbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Testbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testbutton.Location = new System.Drawing.Point(253, 12);
            this.Testbutton.Name = "Testbutton";
            this.Testbutton.Size = new System.Drawing.Size(93, 20);
            this.Testbutton.TabIndex = 1;
            this.Testbutton.Text = "WATCH!";
            this.Testbutton.UseVisualStyleBackColor = false;
            this.Testbutton.Click += new System.EventHandler(this.Testbutton_Click);
            // 
            // Videofenster
            // 
            this.Videofenster.Location = new System.Drawing.Point(12, 38);
            this.Videofenster.MinimumSize = new System.Drawing.Size(20, 20);
            this.Videofenster.Name = "Videofenster";
            this.Videofenster.Size = new System.Drawing.Size(860, 561);
            this.Videofenster.TabIndex = 2;
            // 
            // Chatfenster
            // 
            this.Chatfenster.Location = new System.Drawing.Point(887, 12);
            this.Chatfenster.MinimumSize = new System.Drawing.Size(20, 20);
            this.Chatfenster.Name = "Chatfenster";
            this.Chatfenster.Size = new System.Drawing.Size(285, 587);
            this.Chatfenster.TabIndex = 3;
            // 
            // Nametag
            // 
            this.Nametag.AutoSize = true;
            this.Nametag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nametag.Location = new System.Drawing.Point(801, 12);
            this.Nametag.Name = "Nametag";
            this.Nametag.Size = new System.Drawing.Size(71, 13);
            this.Nametag.TabIndex = 4;
            this.Nametag.Text = "@KOREONE";
            // 
            // hidechatbt
            // 
            this.hidechatbt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.hidechatbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hidechatbt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidechatbt.Location = new System.Drawing.Point(352, 12);
            this.hidechatbt.Name = "hidechatbt";
            this.hidechatbt.Size = new System.Drawing.Size(93, 20);
            this.hidechatbt.TabIndex = 5;
            this.hidechatbt.Text = "HIDE CHAT!";
            this.hidechatbt.UseVisualStyleBackColor = false;
            this.hidechatbt.Click += new System.EventHandler(this.hidechatbt_Click);
            // 
            // Viewercounter
            // 
            this.Viewercounter.AutoSize = true;
            this.Viewercounter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Viewercounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Viewercounter.Location = new System.Drawing.Point(12, 606);
            this.Viewercounter.Name = "Viewercounter";
            this.Viewercounter.Size = new System.Drawing.Size(58, 15);
            this.Viewercounter.TabIndex = 6;
            this.Viewercounter.Text = "Viewers: 0";
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1184, 626);
            this.Controls.Add(this.Viewercounter);
            this.Controls.Add(this.hidechatbt);
            this.Controls.Add(this.Nametag);
            this.Controls.Add(this.Chatfenster);
            this.Controls.Add(this.Videofenster);
            this.Controls.Add(this.Testbutton);
            this.Controls.Add(this.Username_textbox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Hauptfenster";
            this.Text = "Twitch Watcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_textbox;
        private System.Windows.Forms.Button Testbutton;
        private System.Windows.Forms.WebBrowser Videofenster;
        private System.Windows.Forms.WebBrowser Chatfenster;
        private System.Windows.Forms.Label Nametag;
        private System.Windows.Forms.Button hidechatbt;
        private System.Windows.Forms.Label Viewercounter;
    }
}

