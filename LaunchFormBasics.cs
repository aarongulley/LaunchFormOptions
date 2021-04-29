private void UD100Form_BeforeToolClick(object sender, Ice.Lib.Framework.BeforeToolClickEventArgs args)
	{
		switch (args.Tool.Key)
		{
			case "PrintTool":
				if (this.txtKeyField.Text == string.Empty)
				{
					EpiMessageBox.Show("You need a Load Number");
					return;
				}
					LaunchFormOptions lfo = new LaunchFormOptions();
					lfo.IsModal = false;
					lfo.ContextValue = this.txtKeyField.Text;
					ProcessCaller.LaunchForm(oTrans, "OMRM001", lfo);
				break;
			case "ToolBtnUnlockSales":
				if (txtAvailableDate.Text == string.Empty)
				{
					EpiMessageBox.Show("Sales");
					return;
				}
					EpiMessageBox.Show("It's not empty");
				
				break;
			case "ToolBtnUnlockProduction":
				if (txtAvailableDate.Text == string.Empty)
				{
					EpiMessageBox.Show("Production");
					return;
				}
					EpiMessageBox.Show("It's not empty");
				
				break;
	
		}
	}
