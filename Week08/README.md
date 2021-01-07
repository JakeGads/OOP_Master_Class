## Topic:

For this discussion you will research creating custom text processing methods.  For the initial post, discuss a situation where you would create a custom text processing method, as opposed to previously created text processing methods.  For the response post, choose a classmates post and discuss a possible issue with their using a custom method.  Be sure to be in depth and support your posts with justifications.

## Response

Recall back to one of the week 5 problems with the Mechanic Shops, In this problem we listed out the amount of money for each job, when I did this problem instead of having the exact numerical values just add back to a total I instead to wrote a function instead.

```cs
/*
Text should look lik:
Some Words ($10.50) or
Some Words ($1000.00)
*/
public double label_parser(String text)
{
    if (text.Contains("("))
    {
        // looks between the '(' and the ')' and removes `$`,`,` and `_` characters
        return Double.Parse(text.Substring(text.IndexOf("(") + 1, text.IndexOf(")") - (text.IndexOf("(") + 1)).Replace("$", "").Replace(",", "").Replace("_", ""));
    }
    // if the text is invalid return none
    return 0;
}
```

so to this we get a substring of the text between "(" and ")" and replace the general money symbols then parse it and send it back

while thats all fine and dandy you could also you Regex to parse out this data. While I didn't use Regex for the above problem I did use it in the problem for this week. To find and split all capital characters I used

`string[] split = Regex.Split(this.in_tf.Text, @"(?<!^)(?=[A-Z])");`

which gave me array of strings to work with