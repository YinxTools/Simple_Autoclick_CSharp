namespace Simple_Autoclick_CSharp
{
    partial class AutoClicker
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
            this.siticoneTrackBar1 = new Siticone.UI.WinForms.SiticoneTrackBar();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.enabled = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.autoclick = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.KeyBind = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // siticoneTrackBar1
            // 
            this.siticoneTrackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.siticoneTrackBar1.HoveredState.Parent = this.siticoneTrackBar1;
            this.siticoneTrackBar1.LargeChange = 6;
            this.siticoneTrackBar1.Location = new System.Drawing.Point(12, 58);
            this.siticoneTrackBar1.Maximum = 20;
            this.siticoneTrackBar1.Minimum = 6;
            this.siticoneTrackBar1.Name = "siticoneTrackBar1";
            this.siticoneTrackBar1.Size = new System.Drawing.Size(300, 23);
            this.siticoneTrackBar1.TabIndex = 0;
            this.siticoneTrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.siticoneTrackBar1.Value = 13;
            this.siticoneTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneTrackBar1_Scroll);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(73)))), ((int)(((byte)(150)))));
            this.siticoneLabel1.Location = new System.Drawing.Point(12, 12);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(171, 40);
            this.siticoneLabel1.TabIndex = 1;
            this.siticoneLabel1.Text = "AutoClicker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(318, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "13";
            // 
            // enabled
            // 
            this.enabled.CheckedState.Parent = this.enabled;
            this.enabled.CustomImages.Parent = this.enabled;
            this.enabled.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(73)))), ((int)(((byte)(150)))));
            this.enabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enabled.ForeColor = System.Drawing.Color.White;
            this.enabled.HoveredState.Parent = this.enabled;
            this.enabled.Location = new System.Drawing.Point(12, 87);
            this.enabled.Name = "enabled";
            this.enabled.ShadowDecoration.Parent = this.enabled;
            this.enabled.Size = new System.Drawing.Size(144, 24);
            this.enabled.TabIndex = 3;
            this.enabled.Text = "enable";
            this.enabled.Click += new System.EventHandler(this.enabled_Click);
            // 
            // autoclick
            // 
            this.autoclick.Tick += new System.EventHandler(this.autoclick_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Process";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(354, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // bindBtn
            // 
            this.bindBtn.CheckedState.Parent = this.bindBtn;
            this.bindBtn.CustomImages.Parent = this.bindBtn;
            this.bindBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(73)))), ((int)(((byte)(150)))));
            this.bindBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindBtn.ForeColor = System.Drawing.Color.White;
            this.bindBtn.HoveredState.Parent = this.bindBtn;
            this.bindBtn.Location = new System.Drawing.Point(325, 12);
            this.bindBtn.Name = "bindBtn";
            this.bindBtn.ShadowDecoration.Parent = this.bindBtn;
            this.bindBtn.Size = new System.Drawing.Size(41, 19);
            this.bindBtn.TabIndex = 7;
            this.bindBtn.Text = "none";
            this.bindBtn.Click += new System.EventHandler(this.siticoneButton1_Click);
            this.bindBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindBtn_KeyDown);
            // 
            // KeyBind
            // 
            this.KeyBind.Enabled = true;
            this.KeyBind.Tick += new System.EventHandler(this.KeyBind_Tick);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(378, 313);
            this.Controls.Add(this.bindBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enabled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.siticoneTrackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutoClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClicker";
            this.Load += new System.EventHandler(this.AutoClicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneTrackBar siticoneTrackBar1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneRoundedButton enabled;
        private System.Windows.Forms.Timer autoclick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Siticone.UI.WinForms.SiticoneButton bindBtn;
        private System.Windows.Forms.Timer KeyBind;
    }
}

