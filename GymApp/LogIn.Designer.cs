namespace GymApp
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.ColorContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Line = new System.Windows.Forms.Panel();
            this.Log = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LUser = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.Usr = new System.Windows.Forms.TextBox();
            this.menu1 = new Componente.Menu();
            this.ColorContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorContainer
            // 
            this.ColorContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ColorContainer.Controls.Add(this.panel1);
            this.ColorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorContainer.Location = new System.Drawing.Point(0, 0);
            this.ColorContainer.Name = "ColorContainer";
            this.ColorContainer.Size = new System.Drawing.Size(500, 350);
            this.ColorContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.Line);
            this.panel1.Controls.Add(this.Log);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LUser);
            this.panel1.Controls.Add(this.Pwd);
            this.panel1.Controls.Add(this.Usr);
            this.panel1.Controls.Add(this.menu1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 344);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(181, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(133, 136);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Line.Location = new System.Drawing.Point(85, 197);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(330, 3);
            this.Line.TabIndex = 7;
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Log.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(199)))), ((int)(((byte)(57)))));
            this.Log.FlatAppearance.BorderSize = 0;
            this.Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.ForeColor = System.Drawing.Color.White;
            this.Log.Location = new System.Drawing.Point(85, 280);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(328, 39);
            this.Log.TabIndex = 6;
            this.Log.Text = "Iniciar sesion";
            this.Log.UseVisualStyleBackColor = false;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUser.ForeColor = System.Drawing.Color.White;
            this.LUser.Location = new System.Drawing.Point(81, 131);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(77, 25);
            this.LUser.TabIndex = 4;
            this.LUser.Text = "Usuario";
            // 
            // Pwd
            // 
            this.Pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pwd.Location = new System.Drawing.Point(85, 227);
            this.Pwd.Multiline = true;
            this.Pwd.Name = "Pwd";
            this.Pwd.PasswordChar = '*';
            this.Pwd.Size = new System.Drawing.Size(328, 36);
            this.Pwd.TabIndex = 3;
            this.Pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Usr
            // 
            this.Usr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usr.Location = new System.Drawing.Point(85, 155);
            this.Usr.Multiline = true;
            this.Usr.Name = "Usr";
            this.Usr.Size = new System.Drawing.Size(328, 36);
            this.Usr.TabIndex = 2;
            this.Usr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menu1
            // 
            this.menu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu1.BackColor = System.Drawing.Color.Transparent;
            this.menu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu1.Location = new System.Drawing.Point(466, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(28, 50);
            this.menu1.TabIndex = 1;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.ColorContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.ColorContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ColorContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Pwd;
        private System.Windows.Forms.TextBox Usr;
        private Componente.Menu menu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Panel Line;
        private System.Windows.Forms.PictureBox Logo;
    }
}