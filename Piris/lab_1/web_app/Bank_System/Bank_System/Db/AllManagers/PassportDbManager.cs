using Bank_System.Models;

namespace Bank_System.Db.AllManagers
{
    public class PassportDbManager : BaseDbManager<PassportModel>
    {
        public override void UpdateEntity(PassportModel entity)
        {
            var queryString = ComposeUpdateStringStatement(entity);
            dbManager.SendQuery($"update Passport set {queryString} where Id={entity.Id}");
        }

        public override void AddEntity(PassportModel entity)
        {
            var data = ComposeAddStringStatement(entity);
            dbManager.SendQuery($"insert into Passport {data.Item1} values {data.Item2}");
        }
    }
}