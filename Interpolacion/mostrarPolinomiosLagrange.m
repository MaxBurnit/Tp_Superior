function mostrarPolinomiosLagrange(x)
  n = length(x);
  for i = 1 : n
    numerador = '';
    denominador = '';
    polinomio = '';
    den = 1;
    for j = 1 : n
      if j~= i
        numerador = strcat(numerador,'(x-(', num2str(x(j)),'))');
        den = den * (x(i) - x(j));
        denominador = num2str(den);
      endif
    endfor
    polinomio = strcat('L(', num2str(i),')=',numerador, '/', denominador);
    disp(polinomio);
  endfor
endfunction
