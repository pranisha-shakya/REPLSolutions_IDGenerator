using REPLSolutions_IDGenerator.Models;

namespace REPLSolutions_IDGenerator.Services
{
    public interface IIdCardService
    {
        byte[] GenerateIdCard(Student student, School school);
    }
}
