using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
public class Arc 
{
	public Arc(int aCapacitate,Location aLocation,Direction aDirection)
	{
		mDirection = aDirection;
		mLocation = aLocation;
		mCapacitate = aCapacitate;
	}
	
	
	public bool IsValid()
	{
		if(mDirection==Direction.IN)
		{
			return true;
		}
		else
			return (mCapacitate <= mLocation.GetJetoane());
	}
	
	
	public void Update()
	{
		if(mDirection==Direction.IN)
		{
			mLocation.UpdateJetoane(mCapacitate);
		}
		else
		{
			mLocation.UpdateJetoane(-mCapacitate);
		}

	}
	
	public Location GetLocatie()
	{
		return mLocation;
	}
	
	
	private int mCapacitate;
	private Location mLocation;
	private Direction mDirection;
}
}
