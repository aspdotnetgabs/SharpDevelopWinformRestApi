/*
 * Created by SharpDevelop.
 * User: Gabs
 * Date: 10/24/2020
 * Time: 9:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using RestSharp;

namespace SDWinformRestAPI
{
	/// <summary>
	/// Description of LoginForm.
	/// </summary>
	public partial class LoginForm : Form
	{
	  	const string baseUrl = "http://bernardgabon.somee.com";
		IRestClient client = new RestClient(baseUrl);  
		
		public LoginForm()
		{
			InitializeComponent();		
		}
		
		void BtnLoginClick(object sender, EventArgs e)
		{
			// http://bernardgabon.somee.com/TOKEN?username=myuser&password=mypass
			var request = new RestRequest("/TOKEN", Method.POST);
			request.AddQueryParameter("username", txtUsername.Text);
			request.AddQueryParameter("password", txtPassword.Text);			
			var response = client.Execute<ApiUser>(request);
			
			if(response.StatusCode == HttpStatusCode.OK)
			{
				Program.ApiUser = (ApiUser)response.Data; // Cast to ApiUser type and store it to Program.cs ApiUser
				MessageBox.Show("Login successful!");
				btnGetSampleProduct.Enabled= true;
				this.Text += " ===== Current user: " + Program.ApiUser.UserName;
				// Do task for logged-in user...
			}
			else
				MessageBox.Show("Invalid username and/or password.");
			
		}
		
		void BtnRegisterClick(object sender, EventArgs e)
		{
			if(txtNewPassword.Text != txtRetypePassword.Text)
			{
				MessageBox.Show("Password not the same.");
				txtNewPassword.Focus();
				return;
			}
				
			var request = new RestRequest("/api/account/register", Method.POST);
			request.AddQueryParameter("username", txtNewUsername.Text);
			request.AddQueryParameter("password", txtNewPassword.Text);
			var response = client.Execute(request);
			var serverMsg = response.Content;
			
			if(response.StatusCode == HttpStatusCode.OK)
			{
				
				MessageBox.Show("Registration successful! Server says " + serverMsg);
				txtUsername.Focus();
			}
			else
			{
				MessageBox.Show("Registration failed. Please try again. " + serverMsg);	
				txtNewUsername.Focus();
			}
						
		}
		
		void BtnGetSampleProductClick(object sender, EventArgs e)
		{
			if(Program.ApiUser == null || string.IsNullOrEmpty(Program.ApiUser.Token))
			{
				MessageBox.Show("Please login.");
				return;
			}
			   		
			var request = new RestRequest("/api/sample/getproduct", Method.GET);
			// Add authorization header
			request.AddHeader("Authorization", "Bearer " + Program.ApiUser.Token);			
			
			var response = client.Execute(request);
			var productData = response.Content;
			
			if(response.StatusCode == HttpStatusCode.OK)
				MessageBox.Show("PRODUCT DATA: " + productData);
			else
				MessageBox.Show("Unauthorized. " + response.StatusCode.ToString());
			
		}
		
		void BtnLogoutClick(object sender, EventArgs e)
		{
			Program.ApiUser = null;
		}
		

		
	}
}
