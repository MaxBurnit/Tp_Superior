function m = tablaReg(x, n, m)
  for j = 2:n
    for i= n:-1:j
      m(i,j) = (m(i, j-1)-m(i-1,j-1))/((x(i)-x(i-j+1))) ;
     end
  end
endfunction
