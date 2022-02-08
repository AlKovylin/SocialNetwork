using SocialNetwork.DAL.Entities;
using System.Collections.Generic;

namespace SocialNetwork.DAL.Repositories
{
    public class FriendRepository : BaseRepository, IFriendRepository
    {
        public IEnumerable<FriendEntity> FindAllByUserId(int userId)
        {
            return Query<FriendEntity>(@"select * from friends where user_id = :user_id", new { user_id = userId });
        }

        public int Create(FriendEntity friendEntity)
        {
            return Execute(@"insert into friends (user_id,friend_id) values (:user_id,:friend_id)", friendEntity);
        }

        //предложенный вариант
        /*public int Delete(int id)
        {
            return Execute(@"delete from friends where id = :id_p", new { id_p = id });
        }*/

        //отредактированный
        public int Delete(int id)
        {
            return Execute(@"delete from friends where friend_id = :friend_id", new { friend_id = id });
        }
    }

    public interface IFriendRepository
    {
        int Create(FriendEntity friendEntity);
        IEnumerable<FriendEntity> FindAllByUserId(int userId);
        int Delete(int id);
    }
}
