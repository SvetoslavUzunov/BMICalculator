using BMICalculator.MVVM.Models;

namespace BMICalculator.MVVM.ViewModels;

public class BMIViewModel
{
	public BMIViewModel()
	{
		BMI = new BMI
		{
			Height = 180,
			Weight = 73
		};
	}

	public BMI BMI { get; set; }
}
