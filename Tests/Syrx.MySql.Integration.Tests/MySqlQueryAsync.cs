//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.09.30 (00:09)
//  modified     : 2017.10.01 (20:41)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Syrx.Commanders.Databases.Integration.Tests;
using Xunit;

namespace Syrx.MySql.Integration.Tests
{
    [Collection("Syrx.MySql.QueryAsync")]
    public class MySqlQueryAsync : QueryAsync
    {
        public MySqlQueryAsync(MySqlQueryAsyncFixture serverFixture) : base(serverFixture)
        {
        }
    }
}