﻿namespace Models.Entities;

public class Role
{
    public Guid         Id          { get; set; }
    public string       Name        { get; set; } = string.Empty;
    public List<User>   Users       { get; set; } = default!;
    public bool         IsDeleted   { get; set; } = false;
}
