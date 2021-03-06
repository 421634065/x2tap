﻿namespace x2tap.Forms
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.ServerToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.AddSocks5ServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddShadowsocksServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddShadowsocksRServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddVMessServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SubscribeToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.AddSubscribeLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ManageSubscribeLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UpdateServersFromSubscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.GitHubProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TelegramGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TelegramChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.VersionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
			this.SpeedPictureBox = new System.Windows.Forms.PictureBox();
			this.DeletePictureBox = new System.Windows.Forms.PictureBox();
			this.EditPictureBox = new System.Windows.Forms.PictureBox();
			this.ModeComboBox = new System.Windows.Forms.ComboBox();
			this.ModeLabel = new System.Windows.Forms.Label();
			this.ServerComboBox = new System.Windows.Forms.ComboBox();
			this.ServerLabel = new System.Windows.Forms.Label();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.UplinkLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.DownlinkLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ControlButton = new System.Windows.Forms.Button();
			this.SettingsButton = new System.Windows.Forms.Button();
			this.UsedBandwidthLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStrip.SuspendLayout();
			this.ConfigurationGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SpeedPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).BeginInit();
			this.StatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// ToolStrip
			// 
			this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerToolStripDropDownButton,
            this.SubscribeToolStripDropDownButton,
            this.AboutToolStripDropDownButton,
            this.VersionToolStripLabel});
			this.ToolStrip.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip.Name = "ToolStrip";
			this.ToolStrip.Size = new System.Drawing.Size(624, 25);
			this.ToolStrip.TabIndex = 0;
			// 
			// ServerToolStripDropDownButton
			// 
			this.ServerToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSocks5ServerToolStripMenuItem,
            this.AddShadowsocksServerToolStripMenuItem,
            this.AddShadowsocksRServerToolStripMenuItem,
            this.AddVMessServerToolStripMenuItem});
			this.ServerToolStripDropDownButton.Name = "ServerToolStripDropDownButton";
			this.ServerToolStripDropDownButton.Size = new System.Drawing.Size(58, 22);
			this.ServerToolStripDropDownButton.Text = "Server";
			// 
			// AddSocks5ServerToolStripMenuItem
			// 
			this.AddSocks5ServerToolStripMenuItem.Name = "AddSocks5ServerToolStripMenuItem";
			this.AddSocks5ServerToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
			this.AddSocks5ServerToolStripMenuItem.Text = "Add [Socks5] Server";
			this.AddSocks5ServerToolStripMenuItem.Click += new System.EventHandler(this.AddSocks5ServerToolStripMenuItem_Click);
			// 
			// AddShadowsocksServerToolStripMenuItem
			// 
			this.AddShadowsocksServerToolStripMenuItem.Name = "AddShadowsocksServerToolStripMenuItem";
			this.AddShadowsocksServerToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
			this.AddShadowsocksServerToolStripMenuItem.Text = "Add [Shadowsocks] Server";
			this.AddShadowsocksServerToolStripMenuItem.Click += new System.EventHandler(this.AddShadowsocksServerToolStripMenuItem_Click);
			// 
			// AddShadowsocksRServerToolStripMenuItem
			// 
			this.AddShadowsocksRServerToolStripMenuItem.Name = "AddShadowsocksRServerToolStripMenuItem";
			this.AddShadowsocksRServerToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
			this.AddShadowsocksRServerToolStripMenuItem.Text = "Add [ShadowsocksR] Server";
			this.AddShadowsocksRServerToolStripMenuItem.Click += new System.EventHandler(this.AddShadowsocksRServerToolStripMenuItem_Click);
			// 
			// AddVMessServerToolStripMenuItem
			// 
			this.AddVMessServerToolStripMenuItem.Name = "AddVMessServerToolStripMenuItem";
			this.AddVMessServerToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
			this.AddVMessServerToolStripMenuItem.Text = "Add [VMess] Server";
			this.AddVMessServerToolStripMenuItem.Click += new System.EventHandler(this.AddVMessServerToolStripMenuItem_Click);
			// 
			// SubscribeToolStripDropDownButton
			// 
			this.SubscribeToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSubscribeLinkToolStripMenuItem,
            this.ManageSubscribeLinksToolStripMenuItem,
            this.UpdateServersFromSubscriptionsToolStripMenuItem});
			this.SubscribeToolStripDropDownButton.Name = "SubscribeToolStripDropDownButton";
			this.SubscribeToolStripDropDownButton.Size = new System.Drawing.Size(78, 22);
			this.SubscribeToolStripDropDownButton.Text = "Subscribe";
			// 
			// AddSubscribeLinkToolStripMenuItem
			// 
			this.AddSubscribeLinkToolStripMenuItem.Name = "AddSubscribeLinkToolStripMenuItem";
			this.AddSubscribeLinkToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
			this.AddSubscribeLinkToolStripMenuItem.Text = "Add Subscribe Link";
			this.AddSubscribeLinkToolStripMenuItem.Click += new System.EventHandler(this.AddSubscribeLinkToolStripMenuItem_Click);
			// 
			// ManageSubscribeLinksToolStripMenuItem
			// 
			this.ManageSubscribeLinksToolStripMenuItem.Name = "ManageSubscribeLinksToolStripMenuItem";
			this.ManageSubscribeLinksToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
			this.ManageSubscribeLinksToolStripMenuItem.Text = "Manage Subscribe Links";
			this.ManageSubscribeLinksToolStripMenuItem.Click += new System.EventHandler(this.ManageSubscribeLinksToolStripMenuItem_Click);
			// 
			// UpdateServersFromSubscriptionsToolStripMenuItem
			// 
			this.UpdateServersFromSubscriptionsToolStripMenuItem.Name = "UpdateServersFromSubscriptionsToolStripMenuItem";
			this.UpdateServersFromSubscriptionsToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
			this.UpdateServersFromSubscriptionsToolStripMenuItem.Text = "Update Servers From Subscriptions";
			this.UpdateServersFromSubscriptionsToolStripMenuItem.Click += new System.EventHandler(this.UpdateServersFromSubscriptionsToolStripMenuItem_Click);
			// 
			// AboutToolStripDropDownButton
			// 
			this.AboutToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GitHubProjectToolStripMenuItem,
            this.TelegramGroupToolStripMenuItem,
            this.TelegramChannelToolStripMenuItem});
			this.AboutToolStripDropDownButton.Name = "AboutToolStripDropDownButton";
			this.AboutToolStripDropDownButton.Size = new System.Drawing.Size(56, 22);
			this.AboutToolStripDropDownButton.Text = "About";
			// 
			// GitHubProjectToolStripMenuItem
			// 
			this.GitHubProjectToolStripMenuItem.Name = "GitHubProjectToolStripMenuItem";
			this.GitHubProjectToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.GitHubProjectToolStripMenuItem.Text = "GitHub Project";
			this.GitHubProjectToolStripMenuItem.Click += new System.EventHandler(this.GitHubProjectToolStripMenuItem_Click);
			// 
			// TelegramGroupToolStripMenuItem
			// 
			this.TelegramGroupToolStripMenuItem.Name = "TelegramGroupToolStripMenuItem";
			this.TelegramGroupToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.TelegramGroupToolStripMenuItem.Text = "Telegram Group";
			this.TelegramGroupToolStripMenuItem.Click += new System.EventHandler(this.TelegramGroupToolStripMenuItem_Click);
			// 
			// TelegramChannelToolStripMenuItem
			// 
			this.TelegramChannelToolStripMenuItem.Name = "TelegramChannelToolStripMenuItem";
			this.TelegramChannelToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.TelegramChannelToolStripMenuItem.Text = "Telegram Channel";
			this.TelegramChannelToolStripMenuItem.Click += new System.EventHandler(this.TelegramChannelToolStripMenuItem_Click);
			// 
			// VersionToolStripLabel
			// 
			this.VersionToolStripLabel.IsLink = true;
			this.VersionToolStripLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.VersionToolStripLabel.Name = "VersionToolStripLabel";
			this.VersionToolStripLabel.Size = new System.Drawing.Size(83, 22);
			this.VersionToolStripLabel.Text = "1.0.0-STABLE";
			this.VersionToolStripLabel.Click += new System.EventHandler(this.VersionToolStripLabel_Click);
			// 
			// ConfigurationGroupBox
			// 
			this.ConfigurationGroupBox.Controls.Add(this.SpeedPictureBox);
			this.ConfigurationGroupBox.Controls.Add(this.DeletePictureBox);
			this.ConfigurationGroupBox.Controls.Add(this.EditPictureBox);
			this.ConfigurationGroupBox.Controls.Add(this.ModeComboBox);
			this.ConfigurationGroupBox.Controls.Add(this.ModeLabel);
			this.ConfigurationGroupBox.Controls.Add(this.ServerComboBox);
			this.ConfigurationGroupBox.Controls.Add(this.ServerLabel);
			this.ConfigurationGroupBox.Location = new System.Drawing.Point(12, 28);
			this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
			this.ConfigurationGroupBox.Size = new System.Drawing.Size(600, 82);
			this.ConfigurationGroupBox.TabIndex = 1;
			this.ConfigurationGroupBox.TabStop = false;
			this.ConfigurationGroupBox.Text = "Configuration";
			// 
			// SpeedPictureBox
			// 
			this.SpeedPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SpeedPictureBox.Image = global::x2tap.Properties.Resources.speed;
			this.SpeedPictureBox.Location = new System.Drawing.Point(578, 22);
			this.SpeedPictureBox.Name = "SpeedPictureBox";
			this.SpeedPictureBox.Size = new System.Drawing.Size(16, 16);
			this.SpeedPictureBox.TabIndex = 6;
			this.SpeedPictureBox.TabStop = false;
			this.SpeedPictureBox.Click += new System.EventHandler(this.SpeedPictureBox_Click);
			// 
			// DeletePictureBox
			// 
			this.DeletePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DeletePictureBox.Image = global::x2tap.Properties.Resources.delete;
			this.DeletePictureBox.Location = new System.Drawing.Point(556, 22);
			this.DeletePictureBox.Name = "DeletePictureBox";
			this.DeletePictureBox.Size = new System.Drawing.Size(16, 16);
			this.DeletePictureBox.TabIndex = 5;
			this.DeletePictureBox.TabStop = false;
			this.DeletePictureBox.Click += new System.EventHandler(this.DeletePictureBox_Click);
			// 
			// EditPictureBox
			// 
			this.EditPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EditPictureBox.Image = global::x2tap.Properties.Resources.edit;
			this.EditPictureBox.Location = new System.Drawing.Point(534, 22);
			this.EditPictureBox.Name = "EditPictureBox";
			this.EditPictureBox.Size = new System.Drawing.Size(16, 16);
			this.EditPictureBox.TabIndex = 4;
			this.EditPictureBox.TabStop = false;
			this.EditPictureBox.Click += new System.EventHandler(this.EditPictureBox_Click);
			// 
			// ModeComboBox
			// 
			this.ModeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ModeComboBox.FormattingEnabled = true;
			this.ModeComboBox.IntegralHeight = false;
			this.ModeComboBox.Location = new System.Drawing.Point(62, 48);
			this.ModeComboBox.Name = "ModeComboBox";
			this.ModeComboBox.Size = new System.Drawing.Size(466, 24);
			this.ModeComboBox.TabIndex = 3;
			this.ModeComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
			// 
			// ModeLabel
			// 
			this.ModeLabel.AutoSize = true;
			this.ModeLabel.Location = new System.Drawing.Point(10, 52);
			this.ModeLabel.Name = "ModeLabel";
			this.ModeLabel.Size = new System.Drawing.Size(43, 17);
			this.ModeLabel.TabIndex = 2;
			this.ModeLabel.Text = "Mode";
			// 
			// ServerComboBox
			// 
			this.ServerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.ServerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ServerComboBox.FormattingEnabled = true;
			this.ServerComboBox.IntegralHeight = false;
			this.ServerComboBox.Location = new System.Drawing.Point(61, 18);
			this.ServerComboBox.MaxDropDownItems = 30;
			this.ServerComboBox.Name = "ServerComboBox";
			this.ServerComboBox.Size = new System.Drawing.Size(467, 24);
			this.ServerComboBox.TabIndex = 1;
			this.ServerComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
			// 
			// ServerLabel
			// 
			this.ServerLabel.AutoSize = true;
			this.ServerLabel.Location = new System.Drawing.Point(10, 22);
			this.ServerLabel.Name = "ServerLabel";
			this.ServerLabel.Size = new System.Drawing.Size(45, 17);
			this.ServerLabel.TabIndex = 0;
			this.ServerLabel.Text = "Server";
			// 
			// StatusStrip
			// 
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UplinkLabel,
            this.DownlinkLabel,
            this.UsedBandwidthLabel,
            this.StatusLabel});
			this.StatusStrip.Location = new System.Drawing.Point(0, 150);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(624, 22);
			this.StatusStrip.SizingGrip = false;
			this.StatusStrip.TabIndex = 2;
			// 
			// UplinkLabel
			// 
			this.UplinkLabel.Name = "UplinkLabel";
			this.UplinkLabel.Size = new System.Drawing.Size(55, 17);
			this.UplinkLabel.Text = "↑: 0KB/s";
			// 
			// DownlinkLabel
			// 
			this.DownlinkLabel.Name = "DownlinkLabel";
			this.DownlinkLabel.Size = new System.Drawing.Size(55, 17);
			this.DownlinkLabel.Text = "↓: 0KB/s";
			// 
			// StatusLabel
			// 
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(177, 17);
			this.StatusLabel.Text = "Status: Waiting for command";
			// 
			// ControlButton
			// 
			this.ControlButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ControlButton.Location = new System.Drawing.Point(537, 116);
			this.ControlButton.Name = "ControlButton";
			this.ControlButton.Size = new System.Drawing.Size(75, 25);
			this.ControlButton.TabIndex = 3;
			this.ControlButton.Text = "Start";
			this.ControlButton.UseVisualStyleBackColor = true;
			this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
			// 
			// SettingsButton
			// 
			this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SettingsButton.Location = new System.Drawing.Point(12, 116);
			this.SettingsButton.Name = "SettingsButton";
			this.SettingsButton.Size = new System.Drawing.Size(75, 25);
			this.SettingsButton.TabIndex = 4;
			this.SettingsButton.Text = "Settings";
			this.SettingsButton.UseVisualStyleBackColor = true;
			this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
			// 
			// UsedBandwidthLabel
			// 
			this.UsedBandwidthLabel.Name = "UsedBandwidthLabel";
			this.UsedBandwidthLabel.Size = new System.Drawing.Size(68, 17);
			this.UsedBandwidthLabel.Text = "Used: 0KB";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 172);
			this.Controls.Add(this.SettingsButton);
			this.Controls.Add(this.ControlButton);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.ConfigurationGroupBox);
			this.Controls.Add(this.ToolStrip);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "x2tap - Created by Holli_Freed";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ToolStrip.ResumeLayout(false);
			this.ToolStrip.PerformLayout();
			this.ConfigurationGroupBox.ResumeLayout(false);
			this.ConfigurationGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SpeedPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).EndInit();
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip ToolStrip;
		private System.Windows.Forms.ToolStripDropDownButton ServerToolStripDropDownButton;
		private System.Windows.Forms.ToolStripMenuItem AddSocks5ServerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddShadowsocksServerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddShadowsocksRServerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddVMessServerToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton SubscribeToolStripDropDownButton;
		private System.Windows.Forms.ToolStripMenuItem AddSubscribeLinkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem UpdateServersFromSubscriptionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ManageSubscribeLinksToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton AboutToolStripDropDownButton;
		private System.Windows.Forms.ToolStripMenuItem GitHubProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TelegramGroupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TelegramChannelToolStripMenuItem;
		private System.Windows.Forms.ToolStripLabel VersionToolStripLabel;
		private System.Windows.Forms.GroupBox ConfigurationGroupBox;
		private System.Windows.Forms.Label ServerLabel;
		private System.Windows.Forms.ComboBox ModeComboBox;
		private System.Windows.Forms.Label ModeLabel;
		private System.Windows.Forms.PictureBox DeletePictureBox;
		private System.Windows.Forms.PictureBox SpeedPictureBox;
		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.Button ControlButton;
		private System.Windows.Forms.Button SettingsButton;
		private System.Windows.Forms.ToolStripStatusLabel UplinkLabel;
		private System.Windows.Forms.ToolStripStatusLabel DownlinkLabel;
		private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
		private System.Windows.Forms.PictureBox EditPictureBox;
		private System.Windows.Forms.ComboBox ServerComboBox;
		private System.Windows.Forms.ToolStripStatusLabel UsedBandwidthLabel;
	}
}