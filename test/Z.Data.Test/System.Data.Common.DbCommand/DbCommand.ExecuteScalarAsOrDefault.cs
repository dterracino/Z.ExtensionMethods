// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_Common_DbCommand_ExecuteScalarAsOrDefault
    {
        [TestMethod]
        public void ExecuteScalarAsOrDefault()
        {
            const string sql = @"SELECT 'FizzBuzz' As StringColumn";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    var result1 = @this.ExecuteScalarAsOrDefault<string>();
                    var result2 = @this.ExecuteScalarAsOrDefault<int>();
                    int result3 = @this.ExecuteScalarAsOrDefault(-1);
                    int result4 = @this.ExecuteScalarAsOrDefault(command => -2);

                    // UnitTest
                    Assert.AreEqual("FizzBuzz", result1);
                    Assert.AreEqual(0, result2);
                    Assert.AreEqual(-1, result3);
                    Assert.AreEqual(-2, result4);
                }
            }
        }
    }
}