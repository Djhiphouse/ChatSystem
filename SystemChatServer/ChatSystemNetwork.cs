using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
	internal class ChatSystemNetwork
	{





		public class Server
		{
			private int ServerPort { get; set; }
			private IPAddress ServerIP { get; set; }
			TcpClient MessageClient;
			StreamReader Messagereader;
			RichTextBox Chatbox;
			public Server(int Port, IPAddress iPAddress, RichTextBox Box)
			{
				ServerPort = Port;
				ServerIP = iPAddress;
				MessageClient = new TcpClient();
				Chatbox = Box;
			}


			public void Reciver()
			{
				try
				{
					MessageClient.SendTimeout = 2;
					MessageClient.ReceiveTimeout = 2;
					MessageClient.Connect(ServerIP, ServerPort);
				}
				catch (SocketException ex) { MessageBox.Show("Check your Connection!"); return; }

				Messagereader = new StreamReader(MessageClient.GetStream());
				while (MessageClient.Connected)
				{
					String CureentMessage = Messagereader.ReadLine();
					if (CureentMessage != "" || CureentMessage != null)
						return;


					Enum ChatPacket = StringtoEnum(CureentMessage);
					if (ChatPacket == (Enum)Packets.Message)
					{
						OnMessage(GetRawText(ChatPacket, CureentMessage), Chatbox);
					}
					else if (ChatPacket != (Enum)AdminPackets.Admin)
					{
						OnAdminPacket(ChatPacket);
					}
					else
					{
						OnAdminMessage(GetRawText(ChatPacket, CureentMessage), Chatbox);
					}

				}
				return;
			}
			public Enum StringtoEnum(String Packet)
			{
				if (Packet.StartsWith(Packets.Message.ToString()))
					return Packets.Message;
				else if (Packet.StartsWith(AdminPackets.Admin.ToString()))
					return AdminPackets.Admin;
				else if (Packet.StartsWith(AdminPackets.Ban.ToString()))
					return AdminPackets.Ban;
				else if (Packet.StartsWith(AdminPackets.Mute.ToString()))
					return AdminPackets.Mute;
				else if (Packet.StartsWith(AdminPackets.GiveAdmin.ToString()))
					return AdminPackets.GiveAdmin;
				else if (Packet.StartsWith(AdminPackets.Rename.ToString()))
					return AdminPackets.Rename;



				return Packets.Null;
			}

			public String GetRawText(Enum Message, String Text)
			{
				return Text.Replace(Message.ToString(), "");
			}

			public void SendChatMessage(String Message)
			{
				SendPacket(Packets.Message, Message);
			}


			public void SendPacket(Enum Packet, String Text)
			{
				MessageClient.GetStream().Write(Encoding.UTF8.GetBytes(Packet.ToString() + Text + "\n"));
			}
			public enum Packets
			{
				Message,
				Null
			}

			public enum AdminPackets
			{
				Admin,
				Ban,
				Mute,
				Rename,
				GiveAdmin
			}

			public void OnMessage(String Message, RichTextBox ChatBoxMessage)
			{
				ChatBoxMessage.AppendText(Message + "\n");
			}

			public bool OnAdminPacket(Enum Packet)
			{
				switch (Packet)
				{
					case AdminPackets.Ban:

						return true;


					case AdminPackets.Mute:

						return true;


					case AdminPackets.Rename:

						return true;


					case AdminPackets.GiveAdmin:

						return true;



				}

				return false;
			}

			public void OnAdminMessage(String AdminMessae, RichTextBox ChatBoxMessage)
			{
				ChatBoxMessage.AppendText("ADMIN - " + AdminMessae + "\n");
			}
		}

		public class ChatSaver
		{

		}
	}
}
