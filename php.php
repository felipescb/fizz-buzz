<?php

for( $n = 1; $n <= 100; $n ++ )
{
    $output = '';

    if ( $n % 3 == 0 ) $output = 'Fizz';
    if ( $n % 5 == 0 ) $output .= 'Buzz';

    echo ( empty( $output ) ) ? $n : $output, '<br>';
}
