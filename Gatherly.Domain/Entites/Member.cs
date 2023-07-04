﻿using Gatherly.Domain.Primitives;

namespace Gatherly.Domain.Entites;

public class Member : Entity
{
    public Member(Guid id, string firstName, string lastName, string email) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}