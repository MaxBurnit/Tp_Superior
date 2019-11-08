function yi = evaluarEnPunto(m, n, xi,x)
  xt=1;
  yi=m(1,1);
  for j=1:n-1;
    xt=xt.*(xi-x(j));
    yi=yi+m(1,j+1)*xt;
    endfor
endfunction
