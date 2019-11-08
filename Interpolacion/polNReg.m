function [p, yi, m] = polNReg(x, y, xi)
  n = length(x);
  m = zeros(n);
  m(:,1)= y(:);
  
  %obtener tabla de diferencias
  
  m = tablaReg(x, n, m);
  %calcular el dato interpolado
  yi = evaluarEnPunto(m, n, xi,x);
  
  %construir el polinomio
  p = num2str(m(n ,1));
  xx = x*-1;
  for j=2:n
    signo = '';
    if m(n,j) > 0
      signo = '+';
    end
    xt = '';
    for i= 1:j-1;
      signo2 = '+';
      if xx(i)>0;
        signo2 = '+'; 
      end
      xt = strcat(xt,'*(x',signo2, num2str(xx(i)),')');
    end
    p = strcat(p, signo, num2str(m(n,j)), xt);
  end
  
endfunction
