# GitIdentityManager

Very simple utility to manage your git identities.

![git-identity](https://i.imgur.com/pgp9x8T.png)

## Installation

Compile the solution (or download a release) and put `git-identity.exe` in your path.

### git-identity.json

You should create a file name `git-identity.json` next to `git-identity.exe` that contains your identity (or any other git config). The only required fields are `user.name` and `user.email`.

```
[
    {
        "user.name": "John Doe",
        "user.email": "john.doe@personal.space",
        "user.signingkey": "12345566",
        "commit.gpgsign": "true",
        "tag.gpgsign": "true"
    },
    {
        "user.name": "John Doe",
        "user.email": "jdoe@office.corp",
        "user.signingkey": "",
        "commit.gpgsign": "false",
        "tag.gpgsign": "false"
    }
]
```

You can now run `git identity` to change your identity in a local repository.

### Git hooks

It is recommended to set up a global `pre-commit` hook template. A sample hook is provided (`.git-templates` directory in this repository) that checks your identity before committing. See [this post](https://santexgroup.com/blog/create-a-global-git-hook-to-check-flake8-before-each-commit/) for more details.

## Credits

Icon: http://www.iconarchive.com/show/pretty-office-2-icons-by-custom-icon-design/man-icon.html