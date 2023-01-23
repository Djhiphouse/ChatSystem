namespace Snake_Game
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.guna2TaskBarProgress1 = new Guna.UI2.WinForms.Guna2TaskBarProgress(this.components);
			this.Menu = new Guna.UI2.WinForms.Guna2TabControl();
			this.ChatMenu = new System.Windows.Forms.TabPage();
			this.Send = new Guna.UI2.WinForms.Guna2GradientButton();
			this.Message = new Guna.UI2.WinForms.Guna2TextBox();
			this.ChatBox = new System.Windows.Forms.RichTextBox();
			this.AdminMenu = new System.Windows.Forms.TabPage();
			this.Menu.SuspendLayout();
			this.ChatMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// guna2TaskBarProgress1
			// 
			this.guna2TaskBarProgress1.TargetForm = null;
			// 
			// Menu
			// 
			this.Menu.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.Menu.Controls.Add(this.ChatMenu);
			this.Menu.Controls.Add(this.AdminMenu);
			this.Menu.ItemSize = new System.Drawing.Size(180, 40);
			this.Menu.Location = new System.Drawing.Point(2, 1);
			this.Menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Menu.Name = "Menu";
			this.Menu.SelectedIndex = 0;
			this.Menu.Size = new System.Drawing.Size(542, 346);
			this.Menu.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
			this.Menu.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
			this.Menu.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Menu.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
			this.Menu.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
			this.Menu.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
			this.Menu.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
			this.Menu.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Menu.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
			this.Menu.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
			this.Menu.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
			this.Menu.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
			this.Menu.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Menu.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
			this.Menu.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
			this.Menu.TabButtonSize = new System.Drawing.Size(180, 40);
			this.Menu.TabButtonTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.Menu.TabIndex = 0;
			this.Menu.TabMenuBackColor = System.Drawing.Color.Black;
			// 
			// ChatMenu
			// 
			this.ChatMenu.BackColor = System.Drawing.Color.Black;
			this.ChatMenu.Controls.Add(this.Send);
			this.ChatMenu.Controls.Add(this.Message);
			this.ChatMenu.Controls.Add(this.ChatBox);
			this.ChatMenu.Location = new System.Drawing.Point(184, 4);
			this.ChatMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ChatMenu.Name = "ChatMenu";
			this.ChatMenu.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ChatMenu.Size = new System.Drawing.Size(354, 338);
			this.ChatMenu.TabIndex = 1;
			this.ChatMenu.Text = "Chat";
			// 
			// Send
			// 
			this.Send.CustomizableEdges = customizableEdges1;
			this.Send.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.Send.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.Send.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Send.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Send.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.Send.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Send.ForeColor = System.Drawing.Color.White;
			this.Send.Location = new System.Drawing.Point(247, 285);
			this.Send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Send.Name = "Send";
			this.Send.ShadowDecoration.CustomizableEdges = customizableEdges2;
			this.Send.Size = new System.Drawing.Size(111, 52);
			this.Send.TabIndex = 3;
			this.Send.Text = "Send";
			this.Send.Click += new System.EventHandler(this.Send_Click);
			// 
			// Message
			// 
			this.Message.Animated = true;
			this.Message.BorderColor = System.Drawing.Color.Cyan;
			this.Message.BorderThickness = 2;
			this.Message.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Message.CustomizableEdges = customizableEdges3;
			this.Message.DefaultText = "";
			this.Message.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.Message.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.Message.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.Message.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.Message.FillColor = System.Drawing.Color.Transparent;
			this.Message.FocusedState.BorderColor = System.Drawing.Color.Cyan;
			this.Message.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Message.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.Message.Location = new System.Drawing.Point(7, 288);
			this.Message.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Message.Name = "Message";
			this.Message.PasswordChar = '\0';
			this.Message.PlaceholderText = "Type Text..";
			this.Message.SelectedText = "";
			this.Message.ShadowDecoration.CustomizableEdges = customizableEdges4;
			this.Message.Size = new System.Drawing.Size(233, 42);
			this.Message.TabIndex = 2;
			// 
			// ChatBox
			// 
			this.ChatBox.BackColor = System.Drawing.SystemColors.InfoText;
			this.ChatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ChatBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.ChatBox.Location = new System.Drawing.Point(4, 7);
			this.ChatBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ChatBox.Name = "ChatBox";
			this.ChatBox.Size = new System.Drawing.Size(354, 275);
			this.ChatBox.TabIndex = 1;
			this.ChatBox.Text = "                                         No Data..";
			// 
			// AdminMenu
			// 
			this.AdminMenu.BackColor = System.Drawing.Color.Transparent;
			this.AdminMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.AdminMenu.Location = new System.Drawing.Point(184, 4);
			this.AdminMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AdminMenu.Name = "AdminMenu";
			this.AdminMenu.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AdminMenu.Size = new System.Drawing.Size(354, 338);
			this.AdminMenu.TabIndex = 0;
			this.AdminMenu.Text = "Admin Menu";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 345);
			this.Controls.Add(this.Menu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1Load);
			this.Menu.ResumeLayout(false);
			this.ChatMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
		private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2TabControl Menu;
		private System.Windows.Forms.TabPage ChatMenu;
		private Guna.UI2.WinForms.Guna2TextBox Message;
		private System.Windows.Forms.RichTextBox ChatBox;
		private System.Windows.Forms.TabPage AdminMenu;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
		private Guna.UI2.WinForms.Guna2TaskBarProgress guna2TaskBarProgress1;
		private Guna.UI2.WinForms.Guna2GradientButton Send;
	}
}
