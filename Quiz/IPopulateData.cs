using System.Collections.Generic;
using System.Data.Common;

namespace Quiz
{
    public interface IPopulateData
    {
        void PopulateData(DbDataReader dataReader);
    }
}
