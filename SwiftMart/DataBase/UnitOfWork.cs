namespace SwiftMart.DataBase
{
    public class UnitOfWork : IDisposable
    {
        private readonly Context context;

        //public UnitOfWork(Context context)
        //{
        //    this.context = context;
        //    Songs = new SongRepository(context);
        //    Performers = new PerformerRepository(context);
        //    MusicCollections = new MusicCollectionRepository(context);
        //    Radios = new RadioRepository(context);
        //}

        //public ICrudOperations<Song> Songs { get; }
 
        //public ICrudOperations<Performer> Performers { get; }
 
        //public ICrudOperations<MusicCollection> MusicCollections { get; }

        //public ICrudOperations<Radio> Radios { get; }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
