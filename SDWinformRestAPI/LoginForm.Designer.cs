/*
 * Created by SharpDevelop.
 * User: Gabs
 * Date: 10/24/2020
 * Time: 9:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SDWinformRestAPI
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.TextBox txtRetypePassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNewPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNewUsername;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnGetSampleProduct;
		private System.Windows.Forms.Button btnLogout;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.txtRetypePassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNewUsername = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnGetSampleProduct = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnLogin);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(23, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(298, 189);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login";
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(106, 92);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(134, 36);
			this.btnLogin.TabIndex = 12;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(106, 63);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '•';
			this.txtPassword.Size = new System.Drawing.Size(134, 20);
			this.txtPassword.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(36, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Password";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(106, 37);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(134, 20);
			this.txtUsername.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(36, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Username";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnRegister);
			this.groupBox2.Controls.Add(this.txtRetypePassword);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtNewPassword);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtNewUsername);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(347, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(298, 189);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Register";
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(120, 114);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(134, 35);
			this.btnRegister.TabIndex = 14;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.BtnRegisterClick);
			// 
			// txtRetypePassword
			// 
			this.txtRetypePassword.Location = new System.Drawing.Point(120, 88);
			this.txtRetypePassword.Name = "txtRetypePassword";
			this.txtRetypePassword.PasswordChar = '•';
			this.txtRetypePassword.Size = new System.Drawing.Size(134, 20);
			this.txtRetypePassword.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(50, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "Retype";
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Location = new System.Drawing.Point(120, 62);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.PasswordChar = '•';
			this.txtNewPassword.Size = new System.Drawing.Size(134, 20);
			this.txtNewPassword.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(50, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Password";
			// 
			// txtNewUsername
			// 
			this.txtNewUsername.Location = new System.Drawing.Point(120, 36);
			this.txtNewUsername.Name = "txtNewUsername";
			this.txtNewUsername.Size = new System.Drawing.Size(134, 20);
			this.txtNewUsername.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(50, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "Username";
			// 
			// btnGetSampleProduct
			// 
			this.btnGetSampleProduct.Enabled = false;
			this.btnGetSampleProduct.Location = new System.Drawing.Point(59, 245);
			this.btnGetSampleProduct.Name = "btnGetSampleProduct";
			this.btnGetSampleProduct.Size = new System.Drawing.Size(223, 44);
			this.btnGetSampleProduct.TabIndex = 14;
			this.btnGetSampleProduct.Text = "Get Sample Product (Authorized)";
			this.btnGetSampleProduct.UseVisualStyleBackColor = true;
			this.btnGetSampleProduct.Click += new System.EventHandler(this.BtnGetSampleProductClick);
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(397, 245);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(127, 44);
			this.btnLogout.TabIndex = 15;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.BtnLogoutClick);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 314);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnGetSampleProduct);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
