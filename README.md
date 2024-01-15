# Minimal Repo to reproduce a possible bug after migrating from HotChocolate 13.7 to 13.8.1.

Run program, an error is thrown, which was not on HC 13.7, as reported in https://github.com/ChilliCream/graphql-platform/issues/6797.


There seems to be a problem with MutationConventions and enum input parameters with a default value.

Downgrading to 13.7 or removing `.AddMutationConventions()` line from program.cs resolves the issue.

