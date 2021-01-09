namespace CTXUI
{
    partial class UIMessage
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIMessage));
            this.UIHome_Panel4 = new System.Windows.Forms.Panel();
            this.UIHome_Panel2 = new System.Windows.Forms.Panel();
            this.UIHome_Panel17 = new System.Windows.Forms.Panel();
            this.UIHome_Panel3 = new System.Windows.Forms.Panel();
            this.UIHome_TITLE = new System.Windows.Forms.Label();
            this.UIHome_Panel6 = new System.Windows.Forms.Panel();
            this.UIHome_Close = new System.Windows.Forms.Button();
            this.UIHome_MESSAGE = new System.Windows.Forms.RichTextBox();
            this.UIHome_Panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // UIHome_Panel4
            // 
            this.UIHome_Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.UIHome_Panel4.Location = new System.Drawing.Point(-7, 0);
            this.UIHome_Panel4.Name = "UIHome_Panel4";
            this.UIHome_Panel4.Size = new System.Drawing.Size(1300, 1);
            this.UIHome_Panel4.TabIndex = 21;
            // 
            // UIHome_Panel2
            // 
            this.UIHome_Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.UIHome_Panel2.Location = new System.Drawing.Point(-178, 175);
            this.UIHome_Panel2.Name = "UIHome_Panel2";
            this.UIHome_Panel2.Size = new System.Drawing.Size(1300, 1);
            this.UIHome_Panel2.TabIndex = 22;
            // 
            // UIHome_Panel17
            // 
            this.UIHome_Panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.UIHome_Panel17.Location = new System.Drawing.Point(0, -32);
            this.UIHome_Panel17.Name = "UIHome_Panel17";
            this.UIHome_Panel17.Size = new System.Drawing.Size(1, 810);
            this.UIHome_Panel17.TabIndex = 23;
            // 
            // UIHome_Panel3
            // 
            this.UIHome_Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.UIHome_Panel3.Location = new System.Drawing.Point(417, -115);
            this.UIHome_Panel3.Name = "UIHome_Panel3";
            this.UIHome_Panel3.Size = new System.Drawing.Size(1, 810);
            this.UIHome_Panel3.TabIndex = 24;
            // 
            // UIHome_TITLE
            // 
            this.UIHome_TITLE.AutoSize = true;
            this.UIHome_TITLE.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UIHome_TITLE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.UIHome_TITLE.Location = new System.Drawing.Point(6, 2);
            this.UIHome_TITLE.Name = "UIHome_TITLE";
            this.UIHome_TITLE.Size = new System.Drawing.Size(56, 26);
            this.UIHome_TITLE.TabIndex = 0;
            this.UIHome_TITLE.Text = "TITLE";
            // 
            // UIHome_Panel6
            // 
            this.UIHome_Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.UIHome_Panel6.Controls.Add(this.UIHome_Close);
            this.UIHome_Panel6.Controls.Add(this.UIHome_TITLE);
            this.UIHome_Panel6.Location = new System.Drawing.Point(-4, -2);
            this.UIHome_Panel6.Name = "UIHome_Panel6";
            this.UIHome_Panel6.Size = new System.Drawing.Size(1014, 29);
            this.UIHome_Panel6.TabIndex = 26;
            this.UIHome_Panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UIHome_Panel6_MouseDown);
            this.UIHome_Panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UIHome_Panel6_MouseMove);
            this.UIHome_Panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UIHome_Panel6_MouseUp);
            // 
            // UIHome_Close
            // 
            this.UIHome_Close.FlatAppearance.BorderSize = 0;
            this.UIHome_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UIHome_Close.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UIHome_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.UIHome_Close.Image = ((System.Drawing.Image)(resources.GetObject("UIHome_Close.Image")));
            this.UIHome_Close.Location = new System.Drawing.Point(381, 2);
            this.UIHome_Close.Name = "UIHome_Close";
            this.UIHome_Close.Size = new System.Drawing.Size(38, 25);
            this.UIHome_Close.TabIndex = 15;
            this.UIHome_Close.UseVisualStyleBackColor = true;
            this.UIHome_Close.Click += new System.EventHandler(this.UIHome_Close_Click);
            // 
            // UIHome_MESSAGE
            // 
            this.UIHome_MESSAGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.UIHome_MESSAGE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UIHome_MESSAGE.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.UIHome_MESSAGE.ForeColor = System.Drawing.Color.White;
            this.UIHome_MESSAGE.Location = new System.Drawing.Point(6, 29);
            this.UIHome_MESSAGE.Name = "UIHome_MESSAGE";
            this.UIHome_MESSAGE.ReadOnly = true;
            this.UIHome_MESSAGE.Size = new System.Drawing.Size(408, 141);
            this.UIHome_MESSAGE.TabIndex = 27;
            this.UIHome_MESSAGE.Text = "MESSAGE";
            // 
            // UIMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(418, 176);
            this.Controls.Add(this.UIHome_MESSAGE);
            this.Controls.Add(this.UIHome_Panel17);
            this.Controls.Add(this.UIHome_Panel2);
            this.Controls.Add(this.UIHome_Panel4);
            this.Controls.Add(this.UIHome_Panel3);
            this.Controls.Add(this.UIHome_Panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UIMessage_Load);
            this.UIHome_Panel6.ResumeLayout(false);
            this.UIHome_Panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel UIHome_Panel4;
        public System.Windows.Forms.Panel UIHome_Panel2;
        public System.Windows.Forms.Panel UIHome_Panel17;
        public System.Windows.Forms.Panel UIHome_Panel3;
        public System.Windows.Forms.Label UIHome_TITLE;
        public System.Windows.Forms.Panel UIHome_Panel6;
        private System.Windows.Forms.RichTextBox UIHome_MESSAGE;
        public System.Windows.Forms.Button UIHome_Close;
    }
}