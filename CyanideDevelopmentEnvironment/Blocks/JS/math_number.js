function(block, generator) {
    // Numeric value.
    let number = Number(block.getFieldValue("NUM"))
    if (number === Infinity) {
        return ["2147483647", javascript.Order.ATOMIC]
    } else if (number === -Infinity) {
        return ["-2147483647", javascript.Order.UNARY_NEGATION]
    }
    return String(number);
}
