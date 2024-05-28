using Microsoft.Extensions.Logging;
using Models.MetaDBContext;
using Repository.HangHoaRepositorys;

namespace Repository.Common;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly MetasolDBContext _context;
    private readonly ILogger _logger;
    private bool disposeValue;
    public IHangHoaRepository _hanghoa;
    public IHangHoaRepository HangHoas { 
        get
        {
            if (_hanghoa == null)
            {
                _hanghoa = new HangHoaRepository(_context,_logger);
            }
            return _hanghoa;
        } 
    }

    
    // constructor will take the context and logger factory as parameters
    public UnitOfWork(
        MetasolDBContext context,
        ILoggerFactory loggerFactory
    )
    {
        _context = context;
        _logger = loggerFactory.CreateLogger("logs");
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(disposing:true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposeValue)
        {
            if (disposing)
            {
                _context.Dispose();
            }

            disposeValue = true;
        }
    }
}