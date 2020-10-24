/*
 * Created by SharpDevelop.
 * User: Gabs
 * Date: 10/19/2020
 * Time: 11:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using RestSharp;

namespace SDWinformRestAPI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	  	const string baseUrl = "http://bernardgabon.somee.com";
		IRestClient client = new RestClient(baseUrl);  
		
		public MainForm()
		{
			InitializeComponent();			
		}
		
		void GetSongs()
		{
			var request = new RestRequest("/api/song", Method.GET);
			var response = client.Execute<List<Song>>(request);
			var songs = response.Data;
			
			bindingSource1.DataSource = songs;		
		}		
		
		void BtnGetSongsClick(object sender, EventArgs e)
		{
			GetSongs();
			bindingNavigator1.Enabled = true;
			tabControl1.Enabled = true;
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{		
			bindingSource1.EndEdit();			
			var song = (Song)bindingSource1.Current; // Current row/record, Cast to type Song
					
			var request = new RestRequest("/api/Song");		
			if(song.Id > 0)
				// Song has Id, already exists, just update it!							
				request.Method = Method.PUT;		
			else
				// Add new song							
				request.Method = Method.POST;	

			request.RequestFormat = DataFormat.Json;
			request.AddBody(song);
			var response = client.Execute(request);
			
			if(response.StatusCode == HttpStatusCode.OK)
			{
				MessageBox.Show("Successfully saved.");
				GetSongs(); // refresh
			}				
			else
				MessageBox.Show("Saving failed.");			
			
		}	

		void BindingNavigatorDeleteItemClick(object sender, EventArgs e)
		{
			var dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				var song = (Song)bindingSource1.Current;
				
				// http://bernardgabon.somee.com/api/song/id
				var requestDel = new RestRequest("/api/Song/" + song.Id, Method.DELETE);
				var responseDel = client.Execute(requestDel);
				
				if(responseDel.StatusCode == HttpStatusCode.OK)
				{
					bindingSource1.RemoveCurrent();
					MessageBox.Show("Deleted successfully.");					
				}
				else
					MessageBox.Show("Delete failed.");	
			}
					
		}
		
		void BtnLoginDemoClick(object sender, EventArgs e)
		{
			var loginDemo = new LoginForm();
			loginDemo.Show();
		}
				
	}
}
