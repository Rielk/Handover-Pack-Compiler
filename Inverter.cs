using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class InverterData
{
	public string Name { get; set; }
	public string Datasheet { get; set; }
	public bool SolarEdge { get; set; }
}
public class InverterDataSource : BindingSource
{
	private ICollection<InverterData> list;
	public InverterDataSource()
	{
		list = new List<InverterData>();
		DataSource = list;
	}
	public InverterDataSource(IEnumerable<InverterData> data)
	{
		list = data.ToList();
		DataSource = list;
	}
}

