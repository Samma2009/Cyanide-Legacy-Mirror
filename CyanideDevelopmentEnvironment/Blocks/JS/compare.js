function(block, generator) {
    var value_left = generator.valueToCode(block, 'LEFT', Blockly.JavaScript.ORDER_NONE);
    var dropdown_middle = block.getFieldValue('MIDDLE');
    var value_right = generator.valueToCode(block, 'RIGHT', Blockly.JavaScript.ORDER_NONE);
    var code = value_left+" "+dropdown_middle+" "+value_right;
    return code;
};