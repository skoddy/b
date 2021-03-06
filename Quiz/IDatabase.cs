﻿using System.Collections.Generic;

namespace Quiz
{
    public interface IDatabase
    {
        void Connect();
        void Disconnect();
        void Create<T>(string table, T obj);
        List<T> CreateListFromTable<T>(string table, string opt) where T : IPopulateData, new();
        T ReadOne<T>(string table, string opt) where T : IPopulateData, new();
        void Update<T>(string table, T obj);
        void Delete(string table, int id);
    }
}
