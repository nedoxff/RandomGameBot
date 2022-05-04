namespace RandomGameBot.Features.ObjectionLol.Characters;

/*
	Auto generated by my random js script.
	Additional Information:
		Raw Name: Redd White
		Formatted Name: ReddWhite
		Emotion Count: 7
*/
public class ReddWhite : Character<ReddWhite.ReddWhiteEmotions>
{
	public enum ReddWhiteEmotions
	{
		Anguished = 107,
		ArmsCrossed = 108,
		Breakdown = 357,
		Cornered = 111,
		Shine = 112,
		Shrug = 110,
		Stand = 109
	}

	public const string RawName = "Redd White";

	public ReddWhite(string username, ReddWhiteEmotions emotion, string text) : base(username, emotion, text)
	{
	}
}