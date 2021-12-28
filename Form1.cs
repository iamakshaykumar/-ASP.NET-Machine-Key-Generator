﻿//////////////////////////////////////////////////////////////////////////////
// This source code and all associated files and resources are copyrighted by
// the author(s). This source code and all associated files and resources may
// be used as long as they are used according to the terms and conditions set
// forth in The Code Project Open License (CPOL).
//
// Copyright (c) 2011 Jonathan Wood
//

using System;
using System.Windows.Forms;
using BlackBeltCoder;

namespace TestMachineKey
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			MachineKeyVersion version;

			// Get key version
			if (radNet1.Checked)
				version = MachineKeyVersion.Net1;
			else
				version = MachineKeyVersion.Net2;

			// Generate key
			txtMachineKey.Text = MachineKey.Generate(version);
		}
	}
}
