function [p, yi, b] = polNewton(x, y, xi)
  n = length(x);
  b = zeros(n);
  b(:,1)= y(:);
  
  %obtener tabla de diferencias
  
  for j = 2:n
    for i=1:n-j+1
      b(i,j) = (b(i+1, j-1)-b(i,j-1))/((x(i+j-1)-x(i))) ;
     end
  end
  %calcular el dato interpolado
  xt=1;
  yi=b(1,1);
  for j=1:n-1;
    xt=xt.*(xi-x(j));
    yi=yi+b(1,j+1)*xt;
  end
  %construir el polinomio
  p = num2str(b(1,1));
  xx = x*-1;
  for j=2:n
    signo = '';
    if b(1,j) > 0
      signo = '+';
    end
    xt = '';
    for i= 1:j-1;
      signo2 = '+';
      if xx(i)>0;
        signo2 = '+'; 
      end
      xt = strcat(xt, '*(x',signo2, num2str(xx(i)),')');
    end
    p = strcat(p, signo, num2str(b(1,j), xt));
  end
  
endfunction
