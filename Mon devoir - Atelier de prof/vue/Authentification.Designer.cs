
namespace Mon_devoir___Atelier_de_prof.vue
{
    partial class Authentification
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
            this.lbllogn = new System.Windows.Forms.Label();
            this.btnconnect = new System.Windows.Forms.Button();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbllogn
            // 
            this.lbllogn.AutoSize = true;
            this.lbllogn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogn.Location = new System.Drawing.Point(45, 28);
            this.lbllogn.Name = "lbllogn";
            this.lbllogn.Size = new System.Drawing.Size(76, 25);
            this.lbllogn.TabIndex = 0;
            this.lbllogn.Text = "Login : ";
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(135, 211);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(118, 35);
            this.btnconnect.TabIndex = 1;
            this.btnconnect.Text = "se connecter";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpwd.Location = new System.Drawing.Point(35, 121);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(138, 24);
            this.lblpwd.TabIndex = 2;
            this.lblpwd.Text = "Mot de passe : ";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(38, 73);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(215, 22);
            this.txtlogin.TabIndex = 3;
            this.txtlogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(38, 161);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(215, 22);
            this.txtpwd.TabIndex = 4;
            this.txtpwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 260);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.lbllogn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogn;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtpwd;
    }
}