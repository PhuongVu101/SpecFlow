using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManager.Test.Database
{
    public static class ScriptSQL
    {
		public static string DatabaseName = "UniversityManager_Test";

		public static string TablesMasterData = $@"
USE [{DatabaseName}]

/****** Object:  Table [dbo].[Student]    Script Date: 6/18/2021 10:54:35 AM ******/
CREATE TABLE [dbo].[Student](
	[StudentID] [int] NOT NULL,
	[Name] [varchar](225) NOT NULL,
	[Birthday] [date] NOT NULL
 CONSTRAINT [PK_StudentID] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
";
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  