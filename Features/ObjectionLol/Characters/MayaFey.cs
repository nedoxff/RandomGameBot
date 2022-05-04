namespace RandomGameBot.Features.ObjectionLol.Characters;

/*
	Auto generated by my random js script.
	Additional Information:
		Raw Name: Maya Fey
		Formatted Name: MayaFey
		Emotion Count: 5
*/
public class MayaFey : Character<MayaFey.MayaFeyEmotions>
{
	public enum MayaFeyEmotions
	{
		Angry = 105,
		Determined = 102,
		Dull = 104,
		Stand = 106,
		Thinking = 103
	}

	public const string RawName = "Maya Fey";

	public MayaFey(string username, MayaFeyEmotions emotion, string text) : base(username, emotion, text)
	{
	}
}