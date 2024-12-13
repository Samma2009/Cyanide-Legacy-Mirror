//function(block, generator) {
//    var value_cond = generator.valueToCode(block, 'COND', javascript.Order.NONE);
//    var statements_if = generator.valueToCode(block, 'IF', javascript.Order.NONE);
//    var statements_else = generator.valueToCode(block, 'ELSE', javascript.Order.NONE);
//    var code = 'if(' + value_cond + ')\n{\n' + statements_if + '\n}\nelse\n{\n' + statements_else + '\n}\n';
//    return [code, javascript.Order.ATOMIC];
    
//};

function(block, generator) {
    var code = 'if(' + generator.statementToCode(block, 'COND') + ') {\n';
    var nextBlock = block.getInputTargetBlock('IF');
    while (nextBlock) {
        var tempCode = Gen.blockToCode(nextBlock);
        if (Gen.STATEMENT_PREFIX) {
            tempCode = Gen.prefixLines(
                Gen.STATEMENT_PREFIX.replace(/%1/g,
                    '\'' + nextBlock.id + '\'') + '\n', Gen.INDENT) + tempCode;
        }
        code += tempCode;
        nextBlock = nextBlock.getNextBlock();
    }
    code += '}\nelse\n{';
    var nextBlock = block.getInputTargetBlock('ELSE');
    while (nextBlock) {
        var tempCode = Gen.blockToCode(nextBlock);
        if (Gen.STATEMENT_PREFIX) {
            tempCode = Gen.prefixLines(
                Gen.STATEMENT_PREFIX.replace(/%1/g,
                    '\'' + nextBlock.id + '\'') + '\n', Gen.INDENT) + tempCode;
        }
        code += tempCode;
        nextBlock = nextBlock.getNextBlock();
    }
    code += '}\n';
    return code;
};