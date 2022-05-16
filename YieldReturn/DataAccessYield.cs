﻿using System.Collections.Generic;

namespace YieldReturn
{
    public class DataAccessYield
    {
        public static IEnumerable<PersonModel> GetPeople()
        {
            yield return new PersonModel("Leandro", "Reis");
            yield return new PersonModel("Lucas", "Sousa");
            yield return new PersonModel("Teteus", "Reis");
        }
    }
}
