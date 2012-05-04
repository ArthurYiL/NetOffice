using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlSubscribeToFormat
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4147</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlSubscribeToPicture = -4147,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4158</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlSubscribeToText = -4158
	}
}