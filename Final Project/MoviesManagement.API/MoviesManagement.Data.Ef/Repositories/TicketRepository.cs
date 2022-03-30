using Microsoft.EntityFrameworkCore;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.Enum;
using MoviesManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Ef.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly IBaseRepository<Ticket> _repo;

        public TicketRepository(IBaseRepository<Ticket> repo)
        {
            _repo = repo;
        }

        public async Task BuyTicketAsync(Ticket ticket)
        {
            var userTickets = await _repo.Table.SingleOrDefaultAsync(x => x.UserId == ticket.UserId && x.MovieId == ticket.MovieId);
            

            if (userTickets != null && userTickets.State == TicketEnum.Reserved)
            {
                userTickets.State = TicketEnum.Bought;
                await _repo.UpdateAsync(userTickets);
            }
            else
                await _repo.AddAsync(userTickets);
        }

        public async Task CancelTicket(Ticket ticket)
        {
            var userTickets = await _repo.Table.SingleOrDefaultAsync(x => x.UserId == ticket.UserId && x.MovieId == ticket.MovieId);

            if (userTickets.State == TicketEnum.Reserved)
            {
                userTickets.State = TicketEnum.Cancelled;
                await _repo.UpdateAsync(userTickets);
            }
        }

        public async Task TicketReservationAsync(Ticket ticket)
        {
            await _repo.AddAsync(ticket);

        }

        public async Task<bool> TicketBoughtExist(Ticket ticket)
        {
            return await _repo.AnyAsync(x => x.UserId == ticket.UserId && x.MovieId == ticket.MovieId && x.State == TicketEnum.Bought);
        }

        public async Task<bool> TicketReserveExist(Ticket ticket)
        {
            return await _repo.AnyAsync(x => x.UserId == ticket.UserId && x.MovieId == ticket.MovieId && x.State == TicketEnum.Reserved);
        }
    }
}
