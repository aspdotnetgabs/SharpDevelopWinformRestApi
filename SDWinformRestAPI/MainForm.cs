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
		
		void BtnGetSongsClick(object sender, EventArgs e)
		{
			GetSongs();
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			// Create the song object
			var song = new Song();
			song.Id = int.Parse(txtId.Text);
			song.Title = txtTitle.Text;
			song.Artist = txtArtist.Text;
			song.Genre = txtGenre.Text;
			
			// Check if the song exists 			
			var requestGet = new RestRequest("api/song/" + txtId.Text, Method.GET);
			var responseGet = client.Execute<Song>(requestGet);
			
			if(responseGet.StatusCode == HttpStatusCode.OK)
			{
				// Song already exist, just update it!							
				var requestPut = new RestRequest("/api/Song", Method.PUT);
				requestPut.RequestFormat = DataFormat.Json;
				requestPut.AddBody(song);
				var responsePut = client.Execute(requestPut);
				
				if(responsePut.StatusCode == HttpStatusCode.OK)
					MessageBox.Show("Successfully saved.");
				else
					MessageBox.Show("Saving failed.");		
			}			
			else
			{	
				// Add new song				
				var requestPost = new RestRequest("/api/Song", Method.POST);
				requestPost.RequestFormat = DataFormat.Json;
				requestPost.AddBody(song);
				var responsePost = client.Execute(requestPost);
				
				if(responsePost.StatusCode == HttpStatusCode.OK)
					MessageBox.Show("Successfully saved.");
				else
					MessageBox.Show("Saving failed.");	
				
				GetSongs(); // Refresh binding source
			}			
				
		}
		
		void GetSongs()
		{
			var request = new RestRequest("api/song", Method.GET);
			var response = client.Execute<List<Song>>(request);
			var songs = response.Data;
			
			bindingSource1.DataSource = songs;		
		}

		void BindingNavigatorDeleteItemClick(object sender, EventArgs e)
		{
			var dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				// http://bernardgabon.somee.com/api/song/id
				var requestDel = new RestRequest("/api/Song/" + txtId.Text, Method.DELETE);
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
				
	}
}
