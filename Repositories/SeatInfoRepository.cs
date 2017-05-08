using System;
using System.Collections.Generic;
using System.Linq;
using ticketapi.Models;
using ticketapi.Interfaces;
using ticketapi.Contexts;

namespace ticketapi.Repositories
{
    public class SeatInfoRepository : ISeatInfoRepository
    {
        private readonly SeatInfoContext _context;

        public SeatInfoRepository(SeatInfoContext context)
        {
            _context = context;

            foreach (var entity in _context.SeatInfoItems)
                _context.SeatInfoItems.Remove(entity);
            _context.SaveChanges();

            Add(new SeatInfo { id = 1, label = "Boş" });
            Add(new SeatInfo { id = 2, label = "Dolu" });
            Add(new SeatInfo { id = 3, label = "Kapalı" });
            Add(new SeatInfo { id = 4, label = "Vip" });
        }

        public IEnumerable<SeatInfo> GetAll()
        {
            return _context.SeatInfoItems.ToList();
        }

        public void Add(SeatInfo item)
        {
            _context.SeatInfoItems.Add(item);
            _context.SaveChanges();
        }

        public SeatInfo Find(long key)
        {
            return _context.SeatInfoItems.FirstOrDefault(t => t.id == key);
        }

        public void Remove(long key)
        {
            var entity = _context.SeatInfoItems.First(t => t.id == key);
            _context.SeatInfoItems.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(SeatInfo item)
        {
            _context.SeatInfoItems.Update(item);
            _context.SaveChanges();
        }
    }
}