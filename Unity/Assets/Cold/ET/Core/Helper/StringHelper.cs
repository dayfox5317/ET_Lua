using System.Text;

namespace ETCold
{
	public static class StringHelper
	{
		public static byte[] ToByteArray(this string str)
		{
			return Encoding.Default.GetBytes(str);
		}
	}
}
