using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
	public partial class Form1 : Form
	{
		public static RichTextBox Box;
		ChatSystemNetwork.Server Client = new ChatSystemNetwork.Server(8090, IPAddress.Parse("127.0.0.1"), Box);
		public Form1()
		{
			InitializeComponent();
			Box = ChatBox;
		}
		private void Form1Load(object sender, EventArgs e)
		{
			Client.Reciver();
		}

		private void Send_Click(object sender, EventArgs e)
		{
			Client.SendChatMessage(Message.Text);
		}
	}
}
