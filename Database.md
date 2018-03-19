Modern SQL databases are *fast enough*.

If we mark each `Order` as visible to the user (or not) with a `archvied` bit flag, then the active orders should be queried in a less than 20ms.

If we need to display the total `Order` quantity across all `Order Lines` then we can create an indexed view for that.

Similarly we may wish to know the filled quantity per `Order` across all `Order Lines` which, again, we can used and indexed view for.

Joining from the `Order` across the above indexed views should return active orders with details in less than 20ms.
