// Services/TicketService.cs
public class TicketService : ITicketService
{
    private readonly ITicketRepository _ticketRepository;

    public TicketService(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<TicketResponseDto> CreateTicketAsync(CreateTicketDto dto)
    {
        var ticket = new Ticket
        {
            Title       = dto.Title,
            Description = dto.Description,
            Priority    = dto.Priority,
            Status      = "Open",
            CreatedAt   = DateTime.UtcNow
        };

        var created = await _ticketRepository.CreateAsync(ticket);

        return new TicketResponseDto
        {
            Id          = created.Id,
            Title       = created.Title,
            Description = created.Description,
            Priority    = created.Priority,
            Status      = created.Status,
            CreatedAt   = created.CreatedAt
        };
    }

    public async Task<TicketResponseDto> GetTicketByIdAsync(int id)
    {
        var ticket = await _ticketRepository.GetByIdAsync(id);

        if (ticket == null)
            throw new KeyNotFoundException($"Ticket with ID {id} not found.");

        return new TicketResponseDto
        {
            Id          = ticket.Id,
            Title       = ticket.Title,
            Description = ticket.Description,
            Priority    = ticket.Priority,
            Status      = ticket.Status,
            CreatedAt   = ticket.CreatedAt
        };
    }

    public async Task<IEnumerable<TicketResponseDto>> GetAllTicketsAsync()
    {
        var tickets = await _ticketRepository.GetAllAsync();

        return tickets.Select(ticket => new TicketResponseDto
        {
            Id          = ticket.Id,
            Title       = ticket.Title,
            Description = ticket.Description,
            Priority    = ticket.Priority,
            Status      = ticket.Status,
            CreatedAt   = ticket.CreatedAt
        });
    }
}
