using System.Collections.Generic;
using ticketapi.Models;

namespace ticketapi.Interfaces
{
    public interface ISeatInfoRepository
    {
        void Add(SeatInfo item);
        IEnumerable<SeatInfo> GetAll();
        SeatInfo Find(long key);
        void Remove(long key);
        void Update(SeatInfo item);
    }
}