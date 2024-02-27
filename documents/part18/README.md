

## All Dialog Control Preview

### AskQuestion

yes or no.

![image-20240227101338147](./images/image-20240227101338147.png)

### MultiSelectionRequest

Great presence, suitable for multiple options.

![image-20240227101515919](./images/image-20240227101515919.png)

### RequestAlphaEntry

get a character string.

![image-20240227101552070](./images/image-20240227101552070.png)

### RequestEntry

In fact, you can use it to implement all the methods related to Entry, which can be understood as universal, and its functionality is stronger, supporting Scanner.

![image-20240227101649283](./images/image-20240227101649283.png)

### RequestAmountEntry

Get an amount number, it may be null, so don't forget to check it.

![image-20240227101618997](./images/image-20240227101618997.png)

### RequestNumericEntry

Get a number without a decimal point, it may be null, so don't forget to check it.

![image-20240227101822671](./images/image-20240227101822671.png)

### RequestStringEntry

get a string number.

![image-20240227101849477](./images/image-20240227101849477.png)

### SearchRequest

Search by name. For example, Section 1.

![image-20240227101921456](./images/image-20240227101921456.png)

### SelectionRequest

Choose what you want. He has two methods, one is regular array content, and the other is a richer set of objects.

![image-20240227101945207](./images/image-20240227101945207.png)

### ShowError

![image-20240227101959429](./images/image-20240227101959429.png)

### ShowException

I think this is very helpful for developers as they can see detailed errors, which is of great significance.

![image-20240227102034775](./images/image-20240227102034775.png)

### ShowMessage

![image-20240227102055404](./images/image-20240227102055404.png)

### ShowTextList

Can you display some multi line text content, such as logs?

![image-20240227102115128](./images/image-20240227102115128.png)

### SimRequestAmountEntry

Similar to RequestAmountEntry, but its value will never be NULL, which is their difference. And he won't display this default value, which is dependent on the user.

![image-20240227103036480](./images/image-20240227103036480.png)

### SimRequestNumericEntry

Similar to RequestNumericEntry, but its value will never be null, which is their difference. And he won't display this default value, which is dependent on the user.

![image-20240227102343711](./images/image-20240227102343711.png)

### SimSelectionRequest

It looks like SelectionRequest, right? Actually, it doesn't have as many features as SelectionRequest. It only supports IEnumerable.

![image-20240227103100982](./images/image-20240227103100982.png)

### StartProgressRequest

if you span value is 0.

![image-20240227105500350](./images/image-20240227105500350.png)

other span value.

![image-20240227104619061](./images/image-20240227104619061.png)

progressing.

![progressing](./images/progressing.gif)

### UpdateProgressRequest

Associate with **StartProgressRequest**

### EndProgressRequest

Associate with **StartProgressRequest**