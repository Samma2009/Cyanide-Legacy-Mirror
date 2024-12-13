function(block, generator) {

    const PROPERTIES = {
        EVEN: [" % 2 == 0", javascript.Order.MULTIPLICATIVE],
        ODD: [" % 2 == 1", javascript.Order.MULTIPLICATIVE],
        WHOLE: [" % 1 == 0", javascript.Order.MULTIPLICATIVE],
        POSITIVE: [" > 0", javascript.Order.RELATIONAL],
        NEGATIVE: [" < 0", javascript.Order.RELATIONAL],
        DIVISIBLE_BY: ["", javascript.Order.MULTIPLICATIVE],
        PRIME: ["", javascript.Order.NONE]
    }

    const tuple = PROPERTIES[block.getFieldValue("PROPERTY")]
    const operator = tuple[0]
    const order = tuple[1]
    const c = generator.statementToCode(block, "NUMBER_TO_CHECK") || "0"
    return c + operator;

}